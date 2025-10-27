using ClassAssignment.DhofarCarRental.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.DhofarCarRental.Models
{
    public class Car
    {
        public int Id { get; }
        public string Model { get; }
        public decimal DailyRate { get; }
        public CarStatus Status { get; private set; }

        public Car(int id, string model, decimal dailyRate)
        {
            Id = id;
            Model = model;
            DailyRate = dailyRate;
            Status = CarStatus.Available;
        }

        public void Rent()
        {
            if (Status == CarStatus.Available)
                Status = CarStatus.Rented;
            else
                throw new InvalidOperationException("Car is already rented.");
        }

        public void Return()
        {
            if (Status == CarStatus.Rented)
                Status = CarStatus.Available;
            else
                throw new InvalidOperationException("Car is not rented currently.");
        }

        public override string ToString()
        {
            return $"Car {Id}: Model={Model}, Rate={DailyRate:C}, Status={Status}";
        }
    }

}
