using System.Configuration;
using System.Drawing.Drawing2D;

namespace Malovani
{
    public class Shape
    {
        public Point Start { get; set; }

        public Point End { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public ShapeType ShapeType { get; set; }
        public GradientType GradientType { get; set; }
        public List<Point> Points { get; set; }
        public int pen_width { get; set; }
        public int layer { get; set; }
        public bool fill {  get; set; }
        public bool grad { get; set; }
        public double alpha { get; set; }
        


        public Shape(ShapeType Type, bool fill, int layer)
        {
            this.ShapeType = Type;
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
            Color primary = Color.FromArgb((int)alpha, Color1.R, Color1.G, Color1.B);
            Color secondary = Color.FromArgb((int)alpha, Color2.R, Color2.G, Color2.B);

            int width = Math.Abs(this.End.X - this.Start.X);
            int height = Math.Abs(this.End.Y - this.Start.Y);

            int x = Math.Min(this.Start.X, this.End.X);
            int y = Math.Min(this.Start.Y, this.End.Y);

            Pen pen = new Pen(primary);
            Brush brush = new SolidBrush(primary);


            Blend blend = new Blend();

            if (this.End.X == 0 && this.End.Y == 0)
            {
                return;
            }

            
            
            LinearGradientBrush lgb = null;

            if (this.grad)
            {
                switch (this.GradientType)
                {
                    case GradientType.Diagonal:
                        lgb = new LinearGradientBrush(Start, End, Color1, Color2);
                        float[] DlgbRelativeIntensities = { 0.0f, 0.9f, 1.0f };
                        float[] DlgbRelativePositions = { 0.0f, 0.9f, 1.0f };

                        
                        blend.Factors = DlgbRelativeIntensities;
                        blend.Positions = DlgbRelativePositions;
                        lgb.Blend = blend;

                        break;

                    case GradientType.Horizontal:
                        if (Start.X < End.X)
                        {
                            lgb = new LinearGradientBrush(new Rectangle(Start.X, Start.Y, End.X, End.Y), primary, secondary, LinearGradientMode.Horizontal);
                        }
                        else
                        {
                            lgb = new LinearGradientBrush(new Rectangle(End.X, End.Y, Start.X, Start.Y), primary, secondary, LinearGradientMode.Horizontal);
                        }
                        float[] HLgbRelativeIntensities = { 0.0f, 0.5f, 1.0f };
                        float[] HLgbRelativePositions = { 0.0f, 0.5f, 1.0f };

                        blend.Factors = HLgbRelativeIntensities;
                        
                        blend.Positions = HLgbRelativePositions;
                        lgb.Blend = blend;

                        break;

                    case GradientType.Vertical:
                        if (Start.Y < End.Y)
                        {
                            lgb = new LinearGradientBrush(new Rectangle(Start.X, Start.Y, End.X, End.Y), primary, secondary, LinearGradientMode.Vertical);
                        }
                        else
                        {
                            lgb = new LinearGradientBrush(new Rectangle(End.X, End.Y, Start.X, Start.Y), primary, secondary, LinearGradientMode.Vertical);
                        }
                        float[] VLgbRelativeIntensities = { 0.0f, 0.5f, 1.0f };
                        float[] VLgbRelativePositions = { 0.0f, 0.5f, 1.0f };

                        blend.Factors = VLgbRelativeIntensities;
                        blend.Positions = VLgbRelativePositions;
                        lgb.Blend = blend;

                        break;

                }
            }

            
            //OUTLINE + COLOR

            if (this.grad)
            {
                switch (ShapeType)
                {
                    case ShapeType.Line:
                        g.DrawLine(pen, Start, End);
                        break;

                    case ShapeType.Rectangle:
                        switch (GradientType)
                        {
                            case GradientType.Diagonal:
                                g.FillRectangle(lgb, x, y, width, height);
                                break;
                            
                            case GradientType.Horizontal:
                                g.FillRectangle(lgb, x, y, width, height);
                                break;
                            case GradientType.Vertical: 
                                g.FillRectangle(lgb, x, y, width, height);
                                break;
                        }
                        break;
                    case ShapeType.Ellipse:
                        switch (GradientType)
                        {
                            case GradientType.Diagonal:
                                g.FillEllipse(lgb, x, y, width, height);
                                break;
                            case GradientType.Horizontal:
                                g.FillEllipse(lgb, x, y, width, height);
                                break;
                            case GradientType.Vertical:
                                g.FillEllipse(lgb, x, y, width, height);
                                break;
                        }
                        break;

                    case ShapeType.Points:
                        DrawPointLine(g, pen);
                        break;

                    case ShapeType.Eraser:
                        DrawPointLine(g, pen);
                        break;

                }
            }
            else if (fill)
            {
                switch (ShapeType)
                {
                    case ShapeType.Line:
                        g.DrawLine(pen, Start, End);
                        break;

                    case ShapeType.Rectangle:
                        
                        g.FillRectangle(brush, x, y, width, height);
                        break;

                    case ShapeType.Ellipse:
                        
                        g.FillEllipse(brush, x, y, width, height);
                        break;

                    case ShapeType.Points:
                        DrawPointLine(g, pen);
                        break;

                    case ShapeType.Eraser:
                        DrawPointLine(g, pen);
                        break;

                }
            }
            else
            {
                switch (ShapeType)
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