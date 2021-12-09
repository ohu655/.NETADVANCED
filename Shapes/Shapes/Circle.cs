using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; protected set; }

        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public override double CalculatePerimeters()
        {
            return 2 * Math.PI * Radius;
        }

        public override string Draw()
        {
            //StringBuilder sb = new StringBuilder();

            //double rIn = Radius - 0.4;
            //double rOut = Radius + 0.4;

            //for (int i = Radius; i >= -Radius; i--)
            //{
            //    for (double j = -Radius; j < rOut; j += 0.5)
            //    {
            //        double value = i * i + j * j;

            //        if (value >= rIn * rIn && value <= rOut * rOut)
            //        {
            //            sb.Append('*');
            //        }
            //        else
            //        {
            //            sb.Append(' ');
            //        }
            //    }
            //    sb.AppendLine(" ");
            //}

            //return sb.ToString();

            return base.Draw() + " " + this.GetType().Name;
        }
    }
}
