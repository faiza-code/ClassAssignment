using ClassAssignment.DhofarCarRental.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.DhofarCarRental.Models
{
    public class Customer
    {
        public int Id { get; }
        public string Name { get; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"Customer {Id}: {Name}";
    }

  
    public class RentalRecord
    {
        public int Id { get; }
        public Customer Customer { get; }
        public Car Car { get; }
        public int DurationDays { get; }
        public decimal TotalCost { get; }

        public RentalRecord(int id, Customer customer, Car car, int durationDays)
        {
            if (car.Status != CarStatus.Available)
                throw new InvalidOperationException("Car is not available for renting.");

            Id = id;
            Customer = customer;
            Car = car;
            DurationDays = durationDays;
            TotalCost = car.DailyRate * durationDays;
            car.Rent();
        }

        public void ReturnCar()
        {
            Car.Return();
        }

        public override string ToString()
        {
            return $"Rental {Id}: {Customer.Name} rented {Car.Model} for {DurationDays} days, Total Cost={TotalCost:C}";
        }
    }
}
