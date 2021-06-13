using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "123456789", "J.K.Rowling", "Kim Dong");
            Console.WriteLine("ISBN Number\tBook Name\tAuthor Name\tPublisher Name");
            Console.WriteLine(book.GetBookInformation());
            Console.ReadKey();
        }
    }
}
