using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Application.Interfaces.Identities
{
    public interface ITokenCreator
    {
        string Create(string userName, string userRole);
    }
}
