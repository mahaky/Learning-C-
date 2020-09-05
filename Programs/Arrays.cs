using System;


namespace Collections
{
    public class Class1
    {
        static void Main(String[] args)
        {
        //Introduction to Arrays
        //Printings days of week a
            string[] daysofweek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            
            //going through array - Enumerate or Iterate
            
            foreach(string day in daysofweek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
