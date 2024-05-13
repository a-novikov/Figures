using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Figures
{
    public class Elements
    {
        public Ellipse GetEllipse(bool isCircle)
        {
            Random r = new Random();
            Ellipse ellipse = new Ellipse();
            if (isCircle)
            {
                int radius = GetRandomInt();
                ellipse.Width = radius;
                ellipse.Height = radius;
            }
            else
            {
                ellipse.Width = GetRandomInt();
                ellipse.Height = GetRandomInt();
            }
            ellipse.VerticalAlignment = VerticalAlignment.Top;
            ellipse.HorizontalAlignment = HorizontalAlignment.Left;
            ellipse.Stroke = Brushes.Red;
            ellipse.StrokeThickness = 2;

            return ellipse;
        }

        public Rectangle GetRectangle(bool isSquare)
        {
            Random r = new Random();
            Rectangle rectangle = new Rectangle();

            if (isSquare)
            {
                int length = GetRandomInt();
                rectangle.Width = length;
                rectangle.Height = length;
            }
            else
            {
                rectangle.Width = GetRandomInt();
                rectangle.Height = GetRandomInt();
            }

            rectangle.VerticalAlignment = VerticalAlignment.Top;
            rectangle.HorizontalAlignment = HorizontalAlignment.Left;
            rectangle.Stroke = Brushes.Red;
            rectangle.StrokeThickness = 2;

            return rectangle;
        }

        public Polyline GetFigure(int count)
        {
            Polyline polyline = new Polyline();
            Point startPpoint = GetRandomPoint();
            polyline.Points = new PointCollection();

            polyline.Points.Add(startPpoint);

            for (int i = 0; i < count - 1; i++)
            {
                polyline.Points.Add(GetRandomPoint());
            }
            
            polyline.Points.Add(startPpoint);

            polyline.Stroke = Brushes.Red;
            polyline.StrokeThickness = 2;

            return polyline;
        }

        private Point GetRandomPoint()
        {
            Random r = new Random();
            return new Point(GetRandomInt(), GetRandomInt());
        }

        private int GetRandomInt()
        {
            Thread.Sleep(10);
            Random r = new Random();
            return r.Next(50, 300);
        }
    }
}
