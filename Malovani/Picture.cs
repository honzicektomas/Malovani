using Malovani;

namespace WinFormsApp6
{
    public class Picture
    {
        public List<Shape> shapes = new List<Shape>();
        public Select select = new Select();

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
        }

        public void CreateShape(Point P, Color Color1, Color Color2, ShapeType Type, int pen_width, bool fill, bool grad, int layer, int aplha, GradientType gt)
        {
            Shape shape = new Shape(Type, fill, layer)
            {
                Start = P,
                Color1 = Color1,
                pen_width = pen_width,
                Color2 = Color2,
                fill = fill,
                grad = grad,
                layer = layer,
                alpha = aplha,
                GradientType = gt
            };
            this.shapes.Add(shape);
        }

        public void AddPoint(Point point, bool is_shape=true)
        {
            if (!is_shape)
            {
                this.select.End = point;
                return;
            }
            this.shapes.Last().End = point;

            if (this.shapes.Last().ShapeType == ShapeType.Points || this.shapes.Last().ShapeType == ShapeType.Eraser)
            {
                this.shapes.Last().AddPoint(point);
            }
        }
    }
}