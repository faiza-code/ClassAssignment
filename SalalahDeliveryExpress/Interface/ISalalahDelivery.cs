using ClassAssignment.SalalahDeliveryExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahDeliveryExpress.Interface
{
       public  interface ISalalahDelivery
       {
            public static void AddCustomer()
            {
            Console.WriteLine("Add New Customer");
            }
            public void AddDriver();
            public void RemoveCustomer();
            public void  CreateDelivery();
            public void UpdateDelivery();
            public void ShowAllDeliveries();




       }
}
