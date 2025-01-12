using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  1
            Employee emp1 = new Employee(1, "joseph", "M", SecurityLevel.Developer, 90000.00m, new DateTime(2024, 12, 31));
            Console.WriteLine(emp1.ToString());
            Employee[] EmpArr = new Employee[3];

           
            #endregion
            #region   2
            HiringDate hiringDate = new HiringDate(13, 1, 2025);
            Console.WriteLine("Hiring Date: " + hiringDate.ToString());
            #endregion
            #region  3




            #endregion
            #region  5
            EBook ebook = new EBook("C# Programming", "John", "123-456-789", 2.5);
            PrintedBook printedBook = new PrintedBook("C#", "john", "987-654-321", 350);
            Console.WriteLine("EBook Details:");
            ebook.DisplayDetails();
            Console.WriteLine();
            Console.WriteLine("Printed Book Details:");
            printedBook.DisplayDetails();
            #endregion
        }
    }
}
