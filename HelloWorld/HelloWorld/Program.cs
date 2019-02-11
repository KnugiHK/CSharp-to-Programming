using System;

namespace HelloWorld
{
    class Program
    {
        //Start of the program
        static void Main(string[] args)
        {
            //The Write () method outputs one or more values to the screen without a new line character.
            Console.Write("Hello, World!");
            Console.Write("without a new line ");
            //The WriteLine() always appends a new line character to the end of the string.
            //this means any subsequent output will start on a new line.
            Console.WriteLine("Hello, World!);
            Console.WriteLine("subsequent output will start on a new line");
            //Use a built-in input method to prevent closing automatically
            Console.ReadLine();
        }
    }
}
