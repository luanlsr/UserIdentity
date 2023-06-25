using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Exceptions.User
{
    public class NoRegistredUserException : Exception
    {
        public override string Message => "Nenhum usuário cadastrado.";
    }
}
