using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    abstract class Shape3D
    {
        protected double density;
        private static int amount = 0;
        public Shape3D()
        {
            density = 0;
            amount++;
        }
        public Shape3D(double d)
        {
            Density = d;
            amount++;
        }
        public double Density
        {
            get { return density; }
            set
            {
                if (density < 0)
                    density = 0;
                else
                    density = value;
            }
        }
        public static int Amount
        {
            get { return amount; }
        }
        public double Weight()
        {
            return Density * Volume();
        }
        //Virtual Method
        public abstract double Volume();
        
        public string ShowVolumeWeight()
        {
            string str = ShapeProperty();
            str += '\t';
            str += string.Format("{0,8:F2}", density);
            str += '\t';
            str += string.Format("{0,8:F2}", Volume());
            str += '\t';
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }
        public abstract string ShapeProperty();

    }
}
