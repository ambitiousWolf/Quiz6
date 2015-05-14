using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    class Cylinder : Shape3D
    {
        private double radius;
        private double height;
      //  private static double pi = 3.1415926;
        public Cylinder(double radius, double height,double density)
            : base(density)
        {
            Radius = radius;
            Height = height;
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
        public double Height
        {
            get { return height; }
            set
            {
                if (height < 0)
                    height = 0;
                else
                    height = value;
            }
        }
        public override double Volume()
        {
            return GeoConstant.pi * radius * radius * height;
        }


        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Cylinder");
            str += '\t';
            str += string.Format("{0,8:F2}", radius);
            str += '\t';
            str += string.Format("{0,8:F2}", height);
            return str;
        }
    }
}
