using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper_case_char_find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value :");
            char data = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("This is value {0} ",data);

            int f =  32+data;

            char result = (char)f;

            Console.WriteLine(result);

            Console.ReadLine();
            
        }
    }
}
