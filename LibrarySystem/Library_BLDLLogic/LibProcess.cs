using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_BLDLLogic
{
    public class LibProcess
    {
        
        public static bool UpdateBook()
        {
            ViewBooks();
            Console.Write("Enter book number to update: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= books.Count)
            {
                Console.Write("Enter new book title: ");
                string newTitle = Console.ReadLine();
                books[index - 1] = newTitle;
                return true;
            }
            else
            {
                return false;
            }
            return true;
        }
        
    }
}
