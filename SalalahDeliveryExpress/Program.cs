using ClassAssignment.SalalahDeliveryExpress.Enums;
using ClassAssignment.SalalahDeliveryExpress.Models;
using ClassAssignment.SalalahDeliveryExpress.StatusRequest;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Xml.Linq;

namespace ClassAssignment.SalalahDeliveryExpress
{
    public class Program 
    {

        static List<Customers> customers = new List<Customers>();
        static List<Drivers> drivers = new List<Drivers>();
        static List<Delivery> deliveries = new List<Delivery>();

        static void Main(string[] args)
        {

            Console.WriteLine("Wellcome to Salalah Delivery Express");
            Console.WriteLine("Are You Customer Or Driver ?\nEnter 1 for Customer , Enter 2 for Driver , Enter 3 to Show You Deliveries ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    AddCustomer();
                    break;

                case 2:
                    AddDriver();
                    break;

                case 3:
                    ShowAllDeliveries(); 
                    break;
                default:
                    Console.WriteLine("Invalid Input Plase Enter 1 or 2");
                    break;

            }
        }

            public static void AddCustomer()
             {

                 Console.WriteLine("Add Your Information");

                  Console.Write("Enter Your Name : ");
                  string name = Console.ReadLine();

                 Console.Write("Enter Your Phone Number : ");
                 int phoneNumber = int.Parse(Console.ReadLine());

                 Console.Write("Enter Your Email : ");
                 string email = Console.ReadLine();
                
                customers.Add(new Customers(name, phoneNumber, email));

             }

            public  static void AddDriver()
            {

            Console.Write("Enter Driver Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Driver phoneNumber: ");
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Driver Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Driver Car Number: ");
            int carNumber = int.Parse(Console.ReadLine());

            drivers.Add(new Drivers(name,phoneNumber,email,carNumber));
            Console.WriteLine("Driver added successfully.");
            }


           public static void ShowAllDeliveries()
           {
               if (deliveries.Count == 0)
               {
                Console.WriteLine("No deliveries found.");
                return;
               }

                Console.WriteLine("\nAll Deliveries:");
                foreach (var delivery in deliveries)
                {
                Console.WriteLine($"ID: {delivery.Id},Customer: {delivery.Customers.name}, Driver: {delivery.Drivers.name}, Status: {delivery.Status}");
                }
           }




    }






}


























        }

    }
}
