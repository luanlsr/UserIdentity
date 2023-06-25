﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Exceptions.Auth
{
    public class UserNotFoundException : Exception
    {
        public override string Message => "Usuário não encontrado.";
    }
}
