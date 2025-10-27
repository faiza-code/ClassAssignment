using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.SalalahBookCafe.Models
{
    public class Book
    {

        public int Id { get; }
        public string Title { get; }
        public string Author { get; }
        public bool IsBorrowed { get; private set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsBorrowed = false;
        }

        public bool Borrow()
        {
            if (IsBorrowed) return false;
            IsBorrowed = true;
            return true;
        }

        public void Return()
        {
            IsBorrowed = false;
        }
    }
}
