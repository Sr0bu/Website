
using System;

namespace app
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            string pw = "6969";

            Console.WriteLine("Type Password in: ");
            string input = Console.ReadLine();

            if(input == pw){
                Console.WriteLine("Richtig das Password war "+  pw);
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            else{
                Console.WriteLine("False");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }

}