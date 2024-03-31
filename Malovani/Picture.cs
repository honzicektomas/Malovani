using Malovani;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public class Picture
    {
        public List<Shape> shapes = new List<Shape>();

        public void Clear()
        {
            this.shapes.Clear();
        }

        private List<Shape> OrderShapesByLayer(List<Shape> shapes)
        {
            List<Shape> orderedShapes = new List<Shape>(shapes);

            for (int i = 0; i < orderedShapes.Count - 1; i++)
            {
                for (int j = 0; j < orderedShapes.Count - 1 - i; j++)
                {
                    if (orderedShapes[j].layer > orderedShapes[j + 1].layer)
                    {
                        Shape temp = orderedShapes[j];

                        orderedShapes[j] = orderedShapes[j + 1];
                        orderedShapes[j + 1] = temp;
                    }
                }
            }
            return orderedShapes;
        }

        public void Draw(Graphics g)
        {
            List<Shape> orderedShapes = OrderShapesByLayer(this.shapes);

            foreach (Shape shape in orderedShapes)
            {
                shape.Draw(g);
            }
            //foreach (Shape shape in this.shapes.OrderBy(s => s.layer))
            //{
            //    shape.Draw(g);
            //}
        }
        public void CreateShape(Point p, Color color1, ShapeType type, int pen_width, bool fill, Color color2, bool grad, int layer)
        {
            Shape shape = new Shape(type, fill, layer)
            {
                Start = p,
                Color1 = color1,
                pen_width = pen_width,
                Color2 = color2,
                fill = fill,
                grad = grad,
                layer = layer
            };
            this.shapes.Add(shape);
        }

        public void AddPoint(Point point)
        {
            this.shapes.Last().End = point;

            if (this.shapes.Last().Type == ShapeType.Points || this.shapes.Last().Type == ShapeType.Eraser)
            {
                this.shapes.Last().AddPoint(point);
            }
        }
    }
}