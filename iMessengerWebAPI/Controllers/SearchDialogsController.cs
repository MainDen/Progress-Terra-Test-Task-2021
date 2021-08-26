using iMessengerInfrastructureAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iMessengerWebAPI.Controllers
{
    [ApiController]
    public class SearchDialogsController : ControllerBase
    {
        internal IEnumerable<Guid> SearchDialogsByClients(List<Guid> clients)
        {
            if (clients is null)
                throw new ArgumentNullException(nameof(clients));

            var clientsCount = clients.Count;

            using IRGDialogsClientsContext context = new RGDialogsClientsListContext();

            var dialogsClients = context.DialogsClients;

            var dialogsEntryCounts = from dialogClient in dialogsClients
                                     where clients.Contains(dialogClient.IDClient)
                                     group dialogClient by dialogClient.IDRGDialog into IDRGDialog
                                     select new { ID = IDRGDialog.Key, EntryCount = IDRGDialog.Count() };

            var dialogs = from dialogEntryCount in dialogsEntryCounts
                          where dialogEntryCount.EntryCount == clientsCount // the client cannot join the same dialog twice
                          select dialogEntryCount.ID;

            return dialogs;
        }

        [HttpPost]
        [Route("search/by/clients/dialogs/any")]
        public Guid SearchAnyDialogByClients(List<Guid> clients)
        {
            if (clients is null)
                throw new ArgumentNullException(nameof(clients));

            return SearchDialogsByClients(clients).FirstOrDefault();
        }
    }
}
