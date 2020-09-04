using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //using static method by class
            //var p=new Program();
            //Program.Main(args);

            var book=new Book();
            book.AddGrade(92);
            book.AddGrade(34);
            var stats= book.ShowStatistics();
            //Average calaculation using Lists
             Console.WriteLine($"Lowest grade is {stats.Low} ");
             Console.WriteLine($"Highest grade is {stats.High} ");
             Console.WriteLine($"Average grade is {stats.Average} ");

        }
    }
}
