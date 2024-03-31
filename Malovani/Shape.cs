using System.Drawing.Drawing2D;

namespace Malovani
{
    public class Shape
    {
        public Point Start { get; set; }

        public Point End { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public int pen_width { get; set; }
        public int layer { get; set; }
        public bool fill {  get; set; }
        public bool grad { get; set; }
        public ShapeType Type { get; set; }
        public List<Point> Points { get; set; }
        

        public Shape(ShapeType type, bool fill, int layer)
        {
            this.Type = type;
            this.Points = new List<Point>();
            this.layer = layer;
        }
       
        public void AddPoint(Point point)
        {
            Points.Add(point);
        }
        
        private void DrawPointLine(Graphics g, Pen pen)
        {
            if (Points.Count > 0)
            {
                for (int i = 1; i < Points.Count; i++)
                {
                    g.DrawLine(pen, Points[i - 1], Points[i]);
                }
            }
        }

        public void Draw(Graphics g)
        {
            int width = Math.Abs(this.End.X - this.Start.X);
            int height = Math.Abs(this.End.Y - this.Start.Y);

            int x = Math.Min(this.Start.X, this.End.X);
            int y = Math.Min(this.Start.Y, this.End.Y);

            Pen pen = new Pen(Color1, pen_width);
            Brush brush = new SolidBrush(Color2);

            LinearGradientBrush lgb = null;

            if (this.grad)
            {
                lgb = new LinearGradientBrush(Start, End, Color1, Color2);
                float[] relativeIntensities = { 0.0f, 0.9f, 1.0f };
                float[] relativePositions = { 0.0f, 0.9f, 1.0f };

                Blend blend = new Blend();
                blend.Factors = relativeIntensities;
                blend.Positions = relativePositions;
                lgb.Blend = blend;
            }


            //OUTLINE + COLOR

            if (fill)
            {
                switch (Type)
                {
                    case ShapeType.Line:
                        g.DrawLine(pen, Start, End);
                        break;

                    case ShapeType.Rectangle:
                        if (this.grad)
                        {
                            g.FillRectangle(lgb, x, y, width, height);
                            break;
                        }
                        g.FillRectangle(brush, x, y, width, height);
                        break;

                    case ShapeType.Ellipse:
                        if (this.grad)
                        {
                            g.FillEllipse(lgb, x, y, width, height);
                            break;
                        }
                        g.FillEllipse(brush, x, y, width, height);
                        break;

                    case ShapeType.Points:// Draw points connecting them with lines
                        DrawPointLine(g, pen);
                        break;

                    case ShapeType.Eraser:
                        DrawPointLine(g, pen);
                        break;

                }
            }
            else
            {
                switch (Type)
                {
                    case ShapeType.Line:
                        g.DrawLine(pen, Start, End);
                        break;

                    case ShapeType.Rectangle:
                        g.DrawRectangle(pen, x, y, width, height);
                        break;

                    case ShapeType.Ellipse:
                        g.DrawEllipse(pen, x, y, width, height);
                        break;

                    case ShapeType.Points:
                        DrawPointLine(g, pen);
                        break;

                    case ShapeType.Eraser:
                        DrawPointLine(g, pen);
                        break;

                }
            }
        }
    }
}