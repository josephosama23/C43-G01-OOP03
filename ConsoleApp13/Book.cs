using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }


        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }

    public class EBook : Book
    {
       
        public double FileSize { get; set; } 
        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            FileSize = fileSize;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails(); 
            Console.WriteLine($"File Size: {FileSize} MB");
        }
    }

    public class PrintedBook : Book
    {
  
        public int PageCount { get; set; }

       
        public PrintedBook(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails(); 
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }

}
