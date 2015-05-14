using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    class Ball : Shape3D
    {
        private double radius;
       // private static double pi = 3.1415926;
        public Ball(double radius, double density)
            : base(density)
        {
            Radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius < 0)
                    radius = 0;
                else
                    radius = value;
            }
        }
        public override double Volume()
        {
            return 4.0/3*GeoConstant.pi*radius*radius*radius;
        }

      
        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Ball");
            str += '\t';
            str += string.Format("{0,8:F2}", radius);
            str += '\t';
            str += string.Format("{0,8}", "");
            return str;
        }
    }
}
