using ClassAssignment.DhofarCarRental.Enums;
using ClassAssignment.DhofarCarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.DhofarCarRental
{
    public class DhofarCarRental
    {
        private List<Car> cars = new List<Car>();
        private List<Customer> customers = new List<Customer>();
        private List<RentalRecord> rentals = new List<RentalRecord>();

        public void AddCar(Car car) => cars.Add(car);
        public void AddCustomer(Customer customer) => customers.Add(customer);

        public IEnumerable<Car> GetAvailableCars() => cars.Where(c => c.Status == CarStatus.Available);
        public IEnumerable<Car> GetRentedCars() => cars.Where(c => c.Status == CarStatus.Rented);
        public IEnumerable<RentalRecord> GetAllRentals() => rentals;

        public RentalRecord RentCar(int rentalId, int customerId, int carId, int durationDays)
        {
            var customer = customers.FirstOrDefault(c => c.Id == customerId) ?? throw new ArgumentException("Invalid customer ID");
            var car = cars.FirstOrDefault(c => c.Id == carId) ?? throw new ArgumentException("Invalid car ID");

            var rental = new RentalRecord(rentalId, customer, car, durationDays);
            rentals.Add(rental);
            return rental;
        }

        public void ReturnCar(int rentalId)
        {
            var rental = rentals.FirstOrDefault(r => r.Id == rentalId) ?? throw new ArgumentException("Invalid rental ID");
            rental.ReturnCar();
        }

        public decimal GetTotalRevenue()
        {
            return rentals.Sum(r => r.TotalCost);
        }

        // Example usage
        public static void Main()
        {
            var rentalSystem = new DhofarCarRental();

            rentalSystem.AddCar(new Car(1, "Toyota Camry", 50m));
            rentalSystem.AddCar(new Car(2, "Honda Civic", 45m));
            rentalSystem.AddCar(new Car(3, "Ford Explorer", 70m));

            rentalSystem.AddCustomer(new Customer(1, "Sultan"));
            rentalSystem.AddCustomer(new Customer(2, "Aisha"));

            var rental1 = rentalSystem.RentCar(1, 1, 1, 5); // Sultan rents Toyota for 5 days
            Console.WriteLine(rental1);

            var rental2 = rentalSystem.RentCar(2, 2, 2, 3); // Aisha rents Honda for 3 days
            Console.WriteLine(rental2);

            Console.WriteLine("Available cars:");
            foreach (var car in rentalSystem.GetAvailableCars())
                Console.WriteLine(car);

            Console.WriteLine("Returning car for rental 1...");
            rentalSystem.ReturnCar(1);

            Console.WriteLine("Available cars after return:");
            foreach (var car in rentalSystem.GetAvailableCars())
                Console.WriteLine(car);

            Console.WriteLine($"Total revenue: {rentalSystem.GetTotalRevenue():C}");
        }
    }
}
