using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Exceptions.Auth
{
    public class EmailAllReadyExistsException : Exception
    {
        public override string Message => "Email já cadastrado.";
    }
}
