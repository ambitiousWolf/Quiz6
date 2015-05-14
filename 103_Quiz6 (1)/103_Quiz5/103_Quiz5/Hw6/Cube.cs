using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    class Cube : Shape3D
    {
        private double side;

        public Cube(double side, double density)
            : base(density)
        {
            Side = side;
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
        public override double Volume()
        {
            return side*side*side;
        }


        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Cube");
            str += '\t';
            str += string.Format("{0,8:F2}", side);
            str += '\t';
            str += string.Format("{0,8}", "");
            return str;
        }
    }
}
