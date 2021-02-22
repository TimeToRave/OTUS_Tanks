using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Classes
{
	/// <summary>
	///  Координата
	/// </summary>
	class Point
	{
		public Point() : this(0, 0) {}

		public Point(float x, float y)
		{
			X = x;
			Y = y;
		}

		public float X { get; set; }
		public float Y { get; set; }

		public static Point operator +(Point point1, Point point2)
		{
			Point sum = new Point();
			sum.X = point1.X + point2.X;
			sum.Y = point1.Y + point2.Y;
			return sum;
		}

		public override string ToString()
		{
			return String.Format("( {0} ; {1} )", X, Y);
		}

		public void Swap ()
		{
			(X, Y) = (Y, X);
		}
	}
}
