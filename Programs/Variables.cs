using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    class Variables
    {
        // printing variables

        string aFriend = "Mahak";
        Console.WriteLine(aFriend);

        //Building string from constants and variable string

        Console.WriteLine("Hello " + aFriend);

        //String Interpolation

        Console.WriteLine($"Hello {aFriend}");

        //Printing strings

        string firstFriend = "mahak";
        string secondFriend = "lekhu";
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

        //Length function in String
        Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
        Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

    }
}
