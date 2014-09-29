using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radius;


        public double Getdiameter()
        {
            return 2 * radius;
        }
        public double Getperimeter()
        {
            return 2 * radius * Math.PI;
        }
        public double Getarea()
        {
            return radius * radius * Math.PI;
        }
    }
}
