using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahBookCafe.Models
{
    public class Customer
    {
        public int Id { get; }
        public string Name { get; }
        private List<MenuItem> drinkOrders = new List<MenuItem>();
        private List<Book> borrowedBooks = new List<Book>();

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Order a drink
        public void OrderDrink(MenuItem item)
        {
            drinkOrders.Add(item);
            Console.WriteLine($"{Name} ordered {item.Name}");
        }

        // Borrow a book (max 2)
        public bool BorrowBook(Book book)
        {
            if (borrowedBooks.Count >= 2)
            {
                Console.WriteLine($"{Name} cannot borrow more than 2 books.");
                return false;
            }
            if (!book.Borrow())
            {
                Console.WriteLine($"{book.Title} is already borrowed.");
                return false;
            }
            borrowedBooks.Add(book);
            Console.WriteLine($"{Name} borrowed \"{book.Title}\"");
            return true;
        }

        // Return all borrowed books when leaving
        public void Leave()
        {
            foreach (var book in borrowedBooks)
            {
                book.Return();
                Console.WriteLine($"{Name} returned \"{book.Title}\"");
            }
            borrowedBooks.Clear();
            drinkOrders.Clear();
            Console.WriteLine($"{Name} has left the café.");
        }
    }

}
