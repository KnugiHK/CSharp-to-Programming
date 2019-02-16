using System;

namespace HelloWorld
{
    class Program
    {
        //Start of the program
        static void Main(string[] args)
        {
            //The Write () method outputs one or more values to the screen without a new line character(\n).
            Console.Write("Hello, World!");
            Console.Write("Without a new line.");
            //The WriteLine() always appends a new line character(\n) to the end of the string.
            //This means any subsequent output will start on a new line.
            Console.WriteLine("Hello, World!);
            Console.WriteLine("Subsequent output will start on a new line.");
            //Use a built-in input method to prevent closing automatically.
            Console.ReadLine();
        }
    }
}
