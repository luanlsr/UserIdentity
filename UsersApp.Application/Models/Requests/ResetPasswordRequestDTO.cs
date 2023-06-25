using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Application.Models.Requests
{
    public class ResetPasswordRequestDTO
    {
        public string? Email { get; set; }
    }
}
