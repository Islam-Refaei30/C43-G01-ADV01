using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	internal class Helper
	{
		#region SWAP Method
		#region Befor Genenrics
		//public static void SWAP(ref int x, ref int y)
		//{
		//	int temp = x;
		//	x = y;
		//	y = temp;
		//}


		//public static void SWAP(ref double x, ref double y)
		//{
		//	double temp = x;
		//	x = y;
		//	y = temp;
		//}

		//public static void SWAP(ref Point x, ref Point y)
		//{
		//	Point temp = x;
		//	x = y;
		//	y = temp;
		//}

		//public static void SWAP(ref object x, ref object y)
		//{
		//	object temp = x;
		//	x = y;
		//	y = temp;
		//}
		#endregion

		#region After Generics
		//public static void SWAP<T>(ref T x, ref T y)
		//{
		//	T temp = x;
		//	x = y;
		//	y = temp;
		//}
		
		// Compiler can Detect the type of T based on the typr op "Method input parameters"
		// In case Generics type T is declered on method level, Not [class - struct - interface] Level
		#endregion
		#endregion


	}
}
