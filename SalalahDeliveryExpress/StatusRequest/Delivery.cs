using ClassAssignment.SalalahDeliveryExpress.Enums;
using ClassAssignment.SalalahDeliveryExpress.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassAssignment.SalalahDeliveryExpress.StatusRequest
{
    public class Delivery
    {
        
        public int Id { get; set; }
        public Customers Customers { get; set; }

        public Drivers Drivers { get; set; }

        public DeliveryStatus Status { get; set; }

        public Delivery( int id ,Customers customers, Drivers drivers, string status)
        {
            Id = id;
            Customers = customers;
            Drivers = drivers;
            Status = DeliveryStatus.Pending;
        }

        public override string ToString()
        {

            return $"Customer Name : {Customers.name} +Customer PhoneNumber: {Customers.phoneNumber} " +
                   $" + Drivers Name : {Drivers.name} + Drivers PhoneNumber : {Drivers.phoneNumber} + Drivers Car Number : {Drivers.carNumber} "+
                   $"Delivery Status : {Status}" ;
                  
        }

       
    }
}
