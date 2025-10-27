using ClassAssignment.SalalahBookCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahBookCafe
{
    public class SalalahBookCafe
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private List<Book> books = new List<Book>();
        private List<Customer> customers = new List<Customer>();

        public void AddMenuItem(MenuItem item) => menu.Add(item);
        public void AddBook(Book book) => books.Add(book);
        public void AddCustomer(Customer customer) => customers.Add(customer);

        public MenuItem GetMenuItem(int id) => menu.FirstOrDefault(m => m.Id == id);
        public Book GetBook(int id) => books.FirstOrDefault(b => b.Id == id);
        public Customer GetCustomer(int id) => customers.FirstOrDefault(c => c.Id == id);

        // Example usage
        public static void Main()
        {
            var cafe = new SalalahBookCafe();

            // Add menu items
            cafe.AddMenuItem(new MenuItem(1, "Coffee", 2.5m));
            cafe.AddMenuItem(new MenuItem(2, "Tea", 1.8m));

            // Add books
            cafe.AddBook(new Book(1, "The Alchemist", "Paulo Coelho"));
            cafe.AddBook(new Book(2, "One Hundred Years of Solitude", "Gabriel Garcia Marquez"));
            cafe.AddBook(new Book(3, "1984", "George Orwell"));

            // Add customers
            cafe.AddCustomer(new Customer(1, "Salim"));
            cafe.AddCustomer(new Customer(2, "Noura"));

            // Customers order drinks
            var salim = cafe.GetCustomer(1);
            salim.OrderDrink(cafe.GetMenuItem(1));
            salim.OrderDrink(cafe.GetMenuItem(2));

            // Customers borrow books
            salim.BorrowBook(cafe.GetBook(1));
            salim.BorrowBook(cafe.GetBook(3));

            var noura = cafe.GetCustomer(2);
            noura.OrderDrink(cafe.GetMenuItem(2));
            noura.BorrowBook(cafe.GetBook(2));
            noura.BorrowBook(cafe.GetBook(1)); // Already borrowed, will fail

            // Customer leaves, returning books
            salim.Leave();

            // Now Noura can borrow book 1
            noura.BorrowBook(cafe.GetBook(1));

            // Noura leaves
            noura.Leave();
        }
    }
}
