using iMessengerWebAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace iMessengerWebAPI.Tests
{
    [TestClass]
    public class SearchDialogsController_TestClass
    {
        private static readonly Guid s_IDClient1 = new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151");
        private static readonly Guid s_IDClient2 = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820");
        private static readonly Guid s_IDClient3 = new Guid("7de3299b-2796-4982-a85b-2d6d1326396e");
        private static readonly Guid s_IDClient4 = new Guid("0a58955e-342f-4095-88c6-1109d0f70583");
        private static readonly Guid s_IDClient5 = new Guid("50454d55-a73c-4cbc-be25-3c5729dcb82b");
        private static readonly Guid s_IDRGDialog1 = new Guid("fcd6b112-1834-4420-bee6-70c9776f6378");
        private static readonly Guid s_IDRGDialog2 = new Guid("19f6f751-7f8d-41fa-8261-709028650592");
        private static readonly Guid s_IDRGDialog3 = new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f");

        private static void EnumerablesAreEqual(IEnumerable e1, IEnumerable e2)
        {
            if (e1 is null && e2 is null)
                return;

            if (e1 == e2)
                return;

            var en1 = e1.GetEnumerator();
            var en2 = e2.GetEnumerator();
            
            bool b1;
            bool b2;

            while ((b1 = en1.MoveNext()) == (b2 = en2.MoveNext()) && b1)
                Assert.AreEqual(en1.Current, en2.Current);

            Assert.AreEqual(b1, b2);
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsArgumentNullException_ForNull()
        {
            var controller = new SearchDialogsController();

            Assert.ThrowsException<ArgumentNullException>(() => controller.SearchAnyDialogByClients(null));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForEmpty()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid>()));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C1()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { s_IDClient1 }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C2()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { s_IDClient2 }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C3()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { s_IDClient3 }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C4()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { s_IDClient4 }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C5()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { s_IDClient5 }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_D1()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { s_IDRGDialog1 }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_D2()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { s_IDRGDialog2 }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_D3()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { s_IDRGDialog3 }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_E()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(new List<Guid> { Guid.Empty }));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C1_C1()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient1,
            };

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C1_C1_C1()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient1,
                s_IDClient1,
            };

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C1_C1_C2()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient1,
                s_IDClient2,
            };

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C1_C2_C3_C4_C5()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient2,
                s_IDClient3,
                s_IDClient4,
                s_IDClient5,
            };

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsGuidEmpty_ForClients_C1_C2_E()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient2,
                Guid.Empty,
            };

            Assert.AreEqual(Guid.Empty, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsDialog_D1_ForClients_C1_C2_C3()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient2,
                s_IDClient3,
            };

            Assert.AreEqual(s_IDRGDialog1, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsDialog_D1_ForClients_C2_C3_C1()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient2,
                s_IDClient3,
                s_IDClient1,
            };

            Assert.AreEqual(s_IDRGDialog1, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsDialog_D2_ForClients_C1_C2()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient2,
            };

            Assert.AreEqual(s_IDRGDialog2, controller.SearchAnyDialogByClients(clients));
        }
        
        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsDialog_D2_ForClients_C2_C1()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient2,
                s_IDClient1,
            };

            Assert.AreEqual(s_IDRGDialog2, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsDialog_D3_ForClients_C3_C4_C5()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient3,
                s_IDClient4,
                s_IDClient5,
            };

            Assert.AreEqual(s_IDRGDialog3, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchAnyDialogByClients_ReturnsDialog_D3_ForClients_C5_C3_C4()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient5,
                s_IDClient3,
                s_IDClient4,
            };

            Assert.AreEqual(s_IDRGDialog3, controller.SearchAnyDialogByClients(clients));
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsArgumentNullException_ForNull()
        {
            var controller = new SearchDialogsController();

            Assert.ThrowsException<ArgumentNullException>(() => controller.SearchDialogsByClients(null));
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForEmpty()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid>()).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C1()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { s_IDClient1 }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C2()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { s_IDClient2 }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C3()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { s_IDClient3 }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C4()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { s_IDClient4 }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C5()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { s_IDClient5 }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_D1()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { s_IDRGDialog1 }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_D2()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { s_IDRGDialog2 }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_D3()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { s_IDRGDialog3 }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_E()
        {
            var controller = new SearchDialogsController();

            Assert.AreEqual(0, controller.SearchDialogsByClients(new List<Guid> { Guid.Empty }).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C1_C1()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient1,
            };

            Assert.AreEqual(0, controller.SearchDialogsByClients(clients).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C1_C1_C1()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient1,
                s_IDClient1,
            };

            Assert.AreEqual(0, controller.SearchDialogsByClients(clients).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C1_C1_C2()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient1,
                s_IDClient2,
            };

            Assert.AreEqual(0, controller.SearchDialogsByClients(clients).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C1_C2_C3_C4_C5()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient2,
                s_IDClient3,
                s_IDClient4,
                s_IDClient5,
            };

            Assert.AreEqual(0, controller.SearchDialogsByClients(clients).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsEmpty_ForClients_C1_C2_E()
        {
            var controller = new SearchDialogsController();

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient2,
                Guid.Empty,
            };

            Assert.AreEqual(0, controller.SearchDialogsByClients(clients).Count());
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsDialogs_D1_ForClients_C1_C2_C3()
        {
            var controller = new SearchDialogsController();

            List<Guid> dialogs = new List<Guid>
            {
                s_IDRGDialog1,
            };

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient2,
                s_IDClient3,
            };

            EnumerablesAreEqual(dialogs, controller.SearchDialogsByClients(clients));
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsDialogs_D1_ForClients_C2_C3_C1()
        {
            var controller = new SearchDialogsController();

            List<Guid> dialogs = new List<Guid>
            {
                s_IDRGDialog1,
            };

            List<Guid> clients = new List<Guid>
            {
                s_IDClient2,
                s_IDClient3,
                s_IDClient1,
            };

            EnumerablesAreEqual(dialogs, controller.SearchDialogsByClients(clients));
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsDialogs_D2_ForClients_C1_C2()
        {
            var controller = new SearchDialogsController();

            List<Guid> dialogs = new List<Guid>
            {
                s_IDRGDialog2,
            };

            List<Guid> clients = new List<Guid>
            {
                s_IDClient1,
                s_IDClient2,
            };

            EnumerablesAreEqual(dialogs, controller.SearchDialogsByClients(clients));
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsDialogs_D2_ForClients_C2_C1()
        {
            var controller = new SearchDialogsController();

            List<Guid> dialogs = new List<Guid>
            {
                s_IDRGDialog2,
            };

            List<Guid> clients = new List<Guid>
            {
                s_IDClient2,
                s_IDClient1,
            };

            EnumerablesAreEqual(dialogs, controller.SearchDialogsByClients(clients));
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsDialogs_D3_ForClients_C3_C4_C5()
        {
            var controller = new SearchDialogsController();

            List<Guid> dialogs = new List<Guid>
            {
                s_IDRGDialog3,
            };

            List<Guid> clients = new List<Guid>
            {
                s_IDClient3,
                s_IDClient4,
                s_IDClient5,
            };

            EnumerablesAreEqual(dialogs, controller.SearchDialogsByClients(clients));
        }

        [TestMethod]
        public void SearchDialogsByClients_ReturnsDialogs_D3_ForClients_C5_C3_C4()
        {
            var controller = new SearchDialogsController();

            List<Guid> dialogs = new List<Guid>
            {
                s_IDRGDialog3,
            };

            List<Guid> clients = new List<Guid>
            {
                s_IDClient5,
                s_IDClient3,
                s_IDClient4,
            };

            EnumerablesAreEqual(dialogs, controller.SearchDialogsByClients(clients));
        }

    }
}
