//Travis Kean
//String manipulation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Processing_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = args.Length;

            //Reverse order of arguments
            for( int x = i; x > 0; x--)
            {
                Console.WriteLine(args[x -1]);


            }
            Console.WriteLine();

            //Arguments in all upper case

            for(int x = 0; x < i; x++)
            {

                Console.WriteLine(args[x].ToUpper());

            }
            Console.WriteLine();

            //Concatenate all arguments into one string, with a comma

            string newString = "";
            foreach( string s in args)
            {
                if (newString == "")
                    newString = newString + s;
                else
                newString = newString + "," + s;
            
            }
            Console.WriteLine(newString);

            Console.ReadLine();
        }
    }
}
