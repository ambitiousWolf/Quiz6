using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    class Pyramid : Shape3D
    {
        private double side;
        private double height;
        public Pyramid(double side, double height,double density)
            : base(density)
        {
            Side = side;
            Height = height;
        }
        public double Side
        {
            get { return side; }
            set
            {
                if (side < 0)
                    side = 0;
                else
                    side = value;
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
            return 1.0/3*side*side*height;
        }



        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Pyramid");
            str += '\t';
            str += string.Format("{0,8:F2}", side);
            str += '\t';
            str += string.Format("{0,8:F2}", height);
            return str;
        }
    }
}
