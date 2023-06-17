using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Application.Models.Producers;

namespace UsersApp.Application.Interfaces.Produces
{
    public interface IUserMessageProducer
    {
        void Send(UserMessageDTO dto);
    }
}
