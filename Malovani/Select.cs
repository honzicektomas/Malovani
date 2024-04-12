using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp6;

namespace Malovani
{
    public class Select
    {
        public Rectangle rect {  get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
        public int layer { get; set; }
        public Pen pen = new Pen(Color.Black, 1);

        public void DrawRect(Graphics g)
        {
            pen = new Pen(Color.Black, 1);
            int width = Math.Abs(End.X - this.Start.X);
            int height = Math.Abs(this.End.Y - this.Start.Y);

            int x = Math.Min(this.Start.X, this.End.X);
            int y = Math.Min(this.Start.Y, this.End.Y);

            rect = new Rectangle(x, y, width, height);

            g.DrawRectangle(pen, rect);
            
        }

        public void RemoveShapes(List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                Shape shape = shapes[i];

                int width = Math.Abs(shape.End.X - shape.Start.X);
                int height = Math.Abs(shape.End.Y - shape.Start.Y);

                int x = Math.Min(shape.Start.X, shape.End.X);
                int y = Math.Min(shape.Start.Y, shape.End.Y);


                Rectangle ShapeRect = new Rectangle(x, y, width, height);

                

                if (rect.IntersectsWith(ShapeRect))
                {
                    shapes.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
