using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Mainn
    {
        public static void Main()
        {
            Logic l1 = new Logic();
            //Task task1 = l1.CreateClient();
            //Task task1 = l1.GetClient(102);
            Task task1 = l1.GetClients();
            //Task task1 = l1.UpdateClient(102);
            //Task task1 = l1.ArchiveClient(102);
            //Task task1 = l1.DeleteClient(102);
            //Task task1 = l1.RestoreClient(102);
        }
    }
}
//test git
//dfb