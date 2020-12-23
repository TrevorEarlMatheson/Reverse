using System;

namespace Reverse
{
    class Program
    {
        static string GetName()
        {
            Console.WriteLine("Please enter your name:"); //Prompt user for name.
            var name = Console.ReadLine();
            if(name.Replace(" ","") == "")//Ask agian if they enter nothing.
            {
                Console.WriteLine("This is not a valid name try again.");
                return(GetName());
            }
            else
            {
                return(name);
            }
        }

        static string ReverseName()
        {
            var name = GetName();
            var array = new char[name.Length]; //Get the needed length for array based on string length.
            var i = 0;
            foreach(char c in name) //Store each character in array.
            {
                array[i] = c;
                i++;
            }
            Array.Reverse(array); //Reverse array.
            return(string.Join("",array)); //Return string of the reversed array.
        }

        static void PrintName()
        {
            Console.WriteLine("Your name backwards is {0}.", ReverseName()); //Display the reversed string.
        }
        static void Main(string[] args)
        {
            PrintName();
        }
    }
}
