using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	internal class Point:IComparable<Point>
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public override string ToString()
		{
			return $"X = {X}, Y = {Y}";
		}

		public int CompareTo(object? obj)
		{
			Point? point = obj as Point; // Explicit casting  unsafe casting => Invalid casting may throw exception
			
			#region Is Operator for casting
			// is conditional Operator : Return tru in 3 cases
			//1— Obj is Object Of Type "point"
			//2— Obj is Object Of Another Type inheriting From "Point"
			//3- obj is null

			//if (point is Point other02)
			//{
			//	if (other02 is not null) return 1;
			//	if (this.X == other02.X)
			//		return this.Y.CompareTo(other02.Y);
			//	else
			//		return this.X.CompareTo(other02.X);
			//}
			//else
			//	return -1;
			#endregion

			#region As Operator for casting
			// As Casting operator
			/*
			 Casting will succed if and only if ibj if point
			 if casting fails, Will return Null, No Exception
			 */
			Point? other03 = obj as Point;
			if (other03 is null) return 1;
			if (this.X == other03.X)
				return this.Y.CompareTo(other03.Y);
			else
				return this.X.CompareTo(other03.X);
			#endregion
		}

		public int CompareTo(Point? other)
		{
			if (other == null) return 1;
			if (other.GetType() == typeof(Point))
			{
				if (this.X == other.X)
					return other.Y.CompareTo(other.Y);
				else
					return other.X.CompareTo(other.X);
			}
			else
				return 1;


		}
	}
}
