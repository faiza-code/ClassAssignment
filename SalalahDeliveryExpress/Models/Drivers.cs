using ClassAssignment.SalalahDeliveryExpress.Interface;
using ClassAssignment.SalalahDeliveryExpress.StatusRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahDeliveryExpress.Models
{
    public class Drivers : Person
    {
        
        public int carNumber { get; set; } 
        public List<Delivery> Deliveries { get; set; }
        public Delivery Status { get; set; }

        public Drivers(string name, int phoneNumber, string email, int carNumber) 
        : base(name, phoneNumber, email)
        {
            this.carNumber = carNumber;
            Deliveries = new List<Delivery>(); 
        }

        public override string ToString()
        {
            return $"Drivers Name : {name} + Drivers PhoneNumber : {phoneNumber} +" +
                   $" Drivers Email : {email} + Drivers CarNumber : {carNumber}  ";
        }

         









    }
}
