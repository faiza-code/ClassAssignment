
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahDeliveryExpress.Models
{
    public class Customers : Person
    {
        
        public Customers(string name, int phoneNumber, string email ) 
        : base(name, phoneNumber, email)
        {
        }

        public override string ToString()
        {
            return $"Custemer Name : {name} + Custemer PhoneNumber : {phoneNumber} + Custemer Email : {email}  ";
        }

        

















    }

    
}

