using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahDeliveryExpress.Models
{
     public abstract class Person
     {
        public string name { get; set; }

        public int phoneNumber { get; set; }

        public string email { get; set; }

     
        public Person(string name, int phoneNumber, string email)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
           
        }


  





     }
}
