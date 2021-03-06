using iMessengerCoreAPI.Models;
using System;
using System.Collections.Generic;

namespace iMessengerInfrastructureAPI.Data
{
    public interface IDataContext : IDisposable
    {
        IEnumerable<RGDialogsClients> DialogsClients { get; }

        void IDisposable.Dispose() { }
    }
}
