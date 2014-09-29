using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle aCircle=new Circle();
            Console.WriteLine("Enter your input is " );
            aCircle.radius=Convert.ToDouble(Console.ReadLine());

            double diaameter = aCircle.Getdiameter();
            Console.WriteLine("Diameter is "+diaameter);

            double perimeter = aCircle.Getperimeter();
            Console.WriteLine("Perimeter is " + perimeter);

            double area = aCircle.Getarea();
            Console.WriteLine("Area is "+area);

            Console.ReadKey();
        }
    }
}
