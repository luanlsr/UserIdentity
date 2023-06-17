using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Interfaces.Produces;
using UsersApp.Application.Models.Producers;
using UsersApp.Infra.Messages.Settings;

namespace UsersApp.Infra.Messages.Producers
{
    public class UserMessageProducer : IUserMessageProducer
    {
        private readonly MessageSettings? _messageSettings;
        private ConnectionFactory? _connectionFactory;

        public UserMessageProducer(IOptions<MessageSettings> messageSettings)
        {
            _messageSettings = messageSettings.Value;
        }

        public void Send(UserMessageDTO dto)
        {
            ConnectionFactory _connectionFactory = new ConnectionFactory()
            {
                HostName = _messageSettings?.Hostname,
                Port = _messageSettings.Port.Value,
                UserName = _messageSettings.UserName,
                Password = _messageSettings.Password,
            };

            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var model = connection.CreateModel())
                {
                    model.QueueDeclare
                        (
                            queue: _messageSettings.Queue, //nome da fila
                            durable: true, // não apagar a fila quando o servidor do RabbitMQ for desligado
                            exclusive: false, //permitir conexões simultâneas
                            autoDelete: false, //somente a aplicação que irá remover itens da fila
                            arguments: null
                        );

                    //Gravando uma mensagem na fila
                    model.BasicPublish(
                            exchange: string.Empty,
                            routingKey: _messageSettings?.Queue,
                            basicProperties: null,
                            body: Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dto))
                        );
                }
            }
        }
    }
}
