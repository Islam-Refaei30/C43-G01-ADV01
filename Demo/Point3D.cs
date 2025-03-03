using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	internal class Point3D:Point
	{
		public int Z { get; set; }

		public Point3D(int X, int Y, int Z):base( X, Y)
		{
			this.Z = Z;
		}
	}
}
