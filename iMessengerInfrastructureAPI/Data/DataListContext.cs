using iMessengerCoreAPI.Models;
using System.Collections.Generic;

namespace iMessengerInfrastructureAPI.Data
{
    public class DataListContext : IDataContext
    {
        private static readonly object s_latch = new object();

        private static List<RGDialogsClients> s_context;

        public DataListContext()
        {
            lock (s_latch)
                s_context ??= RGDialogsClients.Init();
        }

        public IEnumerable<RGDialogsClients> DialogsClients
        {
            get
            {
                return s_context;
            }
        }
    }
}
