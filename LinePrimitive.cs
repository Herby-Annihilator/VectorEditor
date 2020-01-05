using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GraphicsEditor2
{
    abstract class LinePrimitive : Geometry
    {
        protected float lenght;
        public virtual float Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value <= 0)
                {
                    lenght = 1;
                }
                else
                {
                    lenght = value;
                }
            }
        }
        public LinePrimitive()
        {
            Name = "Default one-dimensional graphics primitive";
            Lenght = 1;
        }
    }
}
