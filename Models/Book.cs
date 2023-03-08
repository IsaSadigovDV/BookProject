using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Book
    {

        public string Name;
        public int PageCount;
        public Book[] books;

        
        public Book(string Name,int PageCount)
        {
            this.Name = Name;
            this.PageCount= PageCount;
        }
        

        public bool Search(Book[] books, string Name, int PageCount)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Name == Name && books[i].PageCount == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        
    }
    
}

