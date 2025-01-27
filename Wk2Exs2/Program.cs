using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Exs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            double length = 0;
            double width = 0;
            double perimeter = 0;
            double area = 0;
            
            //get the length of the rectangle
            Console.WriteLine("what is the length of the rectangle?");
            double length = Convert.ToDouble(Console.ReadLine());

            //get width
            Console.WriteLine("What is the width of the rectangle?");
            double width = Convert.ToDouble(Console.ReadLine());


            //caculate area of rectangle
            double area = length * width;
            Console.WriteLine("The Area of the rectangle is" + area);

            //Calculate perimeter 
            double perimeter = length + length + width + width;
            Console.WriteLine("The perimeter of the recatangle is" + perimeter);

            //pause for user to see
            Console.ReadLine();



        }
    }
}
