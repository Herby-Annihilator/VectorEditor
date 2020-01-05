using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor2
{
    public abstract class SquarePrimitives : Geometry
    {
        //
        // Square
        //
        protected float square;
        public virtual float Square
        {
            get
            {
                return square;
            }
            set
            {
                if (value <= 0)
                {
                    square = 1;
                }
                else
                {
                    square = value;
                }
            }
        }
        //
        // Perimeter
        //
        protected float perimeter;
        public virtual float Perimeter
        {
            get
            {
                return perimeter;
            }
            set
            {
                if (value <= 0)
                {
                    perimeter = 1;
                }
                else
                {
                    perimeter = value;
                }
            }
        }
        public SquarePrimitives()
        {
            square = 1;
            perimeter = 1;
            Name = "SquarePrimitives";
        }
    }
}
