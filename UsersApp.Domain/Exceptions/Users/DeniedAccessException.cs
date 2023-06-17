using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Exceptions.Users
{
    public class DeniedAccessException : Exception
    {
        public override string Message => "Acesso negado. Usuário inválido";
    }
}
