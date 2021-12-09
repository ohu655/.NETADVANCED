using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; protected set; }

        public double Width { get; protected set; }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeters()
        {
            return 2 * (Height + Width);
        }

        public override string Draw()
        {
            //    StringBuilder sb = new StringBuilder();

            //   sb.AppendLine(DrawLine(Width, '*', '*'));

            //    for (int i = 1; i < Height - 1; i++)
            //    {
            //        sb.AppendLine(DrawLine(Width, '*', ' '));
            //    }

            //    sb.AppendLine(DrawLine(Width, '*', '*'));

            //    return sb.ToString();
            //}

            //private string DrawLine(double width, char end, char mid)
            //{
            //    StringBuilder sb = new StringBuilder();

            //    sb.Append(end);
            //    for (int i = 0; i < width - 1; i++)
            //    {
            //        sb.Append(mid);
            //    }
            //    sb.Append(end);

            //    return sb.ToString();

            return base.Draw() + " " + this.GetType().Name;
        }
    }
}
