using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Application.Models.Producers
{
    public class UserMessageDTO
    {
        public MessageType? Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }

    public enum MessageType
    {
        Create_account = 1,
        Reset_password = 2,
    }
}
