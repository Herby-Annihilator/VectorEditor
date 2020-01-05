using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;

namespace GraphicsEditor2
{
    class Line : LinePrimitive
    {
        //
        // start
        //
        protected PointF startPoint;
        public PointF StartPoint
        {
            get
            {
                return startPoint;
            }
            set
            {
                if (value.X < 0)
                {
                    startPoint.X = 0;
                }
                else
                {
                    startPoint.X = value.X;
                }
                if (value.Y < 0)
                {
                    startPoint.Y = 0;
                }
                else
                {
                    startPoint.Y = value.Y;
                }
            }
        }
        //
        // end
        //
        protected PointF endPoint;
        public PointF EndPoint
        {
            get
            {
                return endPoint;
            }
            set
            {
                if (value.X < 0)
                {
                    endPoint.X = 0;
                }
                else
                {
                    endPoint.X = value.X;
                }
                if (value.Y < 0)
                {
                    endPoint.Y = 0;
                }
                else
                {
                    endPoint.Y = value.Y;
                }
            }
        }
        public override float Lenght 
        { 
            get
            {
                float xx = (endPoint.X - startPoint.X) * (endPoint.X - startPoint.X);
                float yy = (endPoint.Y - startPoint.Y) * (endPoint.Y - startPoint.Y);
                return (float)Math.Sqrt(xx + yy);
            }
            set => base.Lenght = value;
        }
        //
        // Constructors
        //
        public Line()
        {
            Name = "Line";
            StartPoint = new PointF(1, 1);
            EndPoint = new PointF(2, 2);
        }
        public Line(PointF start, PointF end)
        {
            StartPoint = start;
            EndPoint = end;
            Name = "Line";
        }
        public Line(PointF start, PointF end, float thickness) : this(start, end)
        {
            Thickness = thickness;
        }
        public Line(PointF start, PointF end, float thickness, Color color) : this(start, end, thickness)
        {
            GeometryColor = color;
        }
        public Line(float x1, float y1, float x2, float y2) : this(new PointF(x1, x2), new PointF(x2, y2))
        {

        }
        public Line(float x1, float y1, float x2, float y2, float thickness) : this(new PointF(x1, x2), new PointF(x2, y2), thickness)
        {

        }
        public Line(float x1, float y1, float x2, float y2, float thickness, Color color) : this(new PointF(x1, x2), new PointF(x2, y2), thickness, color)
        {

        }
        /// <summary>
        /// Нарисует линию
        /// </summary>
        /// <param name="control"></param>
        public override void Draw(Control control)
        {
            Graphics graphics = control.CreateGraphics();
            graphics.DrawLine(new Pen(GeometryColor, thickness), StartPoint, EndPoint);
            graphics.Dispose();
        }
        /// <summary>
        /// Сохранит линию в указанный файл
        /// </summary>
        /// <param name="fileName"></param>
        public override void SaveToFile(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            if (writer == null)
            {
                throw new FileNotFoundException("Файл не найден или не создан");
            }
            writer.WriteLine(writer.NewLine + "<begin>");
            writer.WriteLine(this.Name);
            writer.WriteLine(Lenght);
            writer.WriteLine(thickness);
            writer.WriteLine(GeometryColor.Name);
            writer.WriteLine(startPoint.X + " " + startPoint.Y);
            writer.WriteLine(endPoint.X + " " + endPoint.Y);
            writer.WriteLine("<end>" + writer.NewLine);
            writer.Close();
        }
    }
}
