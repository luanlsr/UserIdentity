﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Infra.Messages.Settings
{
    public class MessageSettings
    {
        public string? Hostname { get; set; }
        public int? Port { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Queue { get; set; }
    }
}
