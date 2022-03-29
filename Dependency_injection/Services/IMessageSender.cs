using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_injection.Services
{
    public interface IMessageSender
    {
        string Send();
    }
}
