using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor2
{
    abstract class Geometry
    {
        public virtual Color GeometryColor { get; set; }

        public Geometry()
        {
            GeometryColor = Color.Black;
            Name = "Default graphics primitive";
            thickness = 1;
        }
        /// <summary>
        /// Название объекта
        /// </summary>
        public virtual string Name { get; protected set; }
        public abstract void Draw(Control control);
        /// <summary>
        /// Толщина
        /// </summary>
        protected float thickness;
        /// <summary>
        /// Свойство, задающее толщину. Измеряется в пикселях
        /// </summary>
        public virtual float Thickness
        {
            get
            {
                return thickness;
            }
            set
            {
                if (value <= 0)
                {
                    thickness = 1;
                }
                else if (value > 50)
                {
                    thickness = 50;
                }
                else
                {
                    thickness = value;
                }
            }
        }
        /// <summary>
        /// Фигура или примитив должны уметь сохраняться в файл
        /// </summary>
        /// <param name="fileName"></param>
        public abstract void SaveToFile(string fileName);
    }
}
