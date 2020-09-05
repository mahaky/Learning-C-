using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            static void Main(String[] args)
            {
                string[] daysofweek =
                {
                "Monday",
                "Tuesday",}
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            
            //Accessing arrays through index
            
            //Arrays start with zero index
            
                Console.WriteLine("Which day you want to display");
                Console.WriteLine("Monday=1 and so on");
                int iday = int.Parse(Console.ReadLine());
                
            /*If indexing needs to start from 1 subtract 1
            string daytoshow = daysofweek[iday-1];*/
            
                string daytoshow = daysofweek[iday];
                Console.WriteLine($"The day is {daytoshow}");
                
            //Replacing in array
            
                 daysofweek[2]="Wed";
                 Console.WriteLine(daysofweek[2]);
            
                }
         }
  }
                
