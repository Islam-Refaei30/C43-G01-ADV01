using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	internal class Helper<T> where T:IComparable
	{
		#region SWAP Method
		#region Befor Genenrics
		public static void SWAP(ref int x, ref int y)
		{
			int temp = x;
			x = y;
			y = temp;
		}


		public static void SWAP(ref double x, ref double y)
		{
			double temp = x;
			x = y;
			y = temp;
		}

		public static void SWAP(ref Point x, ref Point y)
		{
			Point temp = x;
			x = y;
			y = temp;
		}

		public static void SWAP(ref object x, ref object y)
		{
			object temp = x;
			x = y;
			y = temp;
		}
		#endregion

		#region After Generics
		public static void SWAP<T>(ref T x, ref T y)
		{
			T temp = x;
			x = y;
			y = temp;
		}

		// Compiler can Detect the type of T based on the typr op "Method input parameters"
		// In case Generics type T is declered on method level, Not [class - struct - interface] Level
		#endregion
		#endregion

		#region Search Example
		//public static int SearchArray(int[] Array, int Value)
		//{
		//	if (Array is not null)
		//	{
		//		for (int i = 0; i < Array.Length; i++)
		//		{
		//			if (Value == Array[i])
		//				return i;
		//		}
		//	}
		//	return -1;
		//}

		public static int SearchArray(T[] Array, T Value)
		{
			if(Array is not null)
			{
				for (int i = 0; i < Array.Length; i++)
				{
					if (Value.Equals(Array[i]))
						return i;
				}
			}
			return -1;
		}
		#endregion

		#region Bubble Sort
		public static void BubbleSort(T[] Array)
		{
			if( Array is not null )
			{
				for(int i = 0;i < Array.Length;i++)
				{
					for(int j = 0; j<Array.Length -i-1; j++)
					{
						//if (Array[j] > Array[j+1])
						if (Array[j].CompareTo(Array[j+1]) == 1)
							Helper<int>.SWAP(ref Array[j], ref Array[j+1]);
					}
				}
			}
		}
		#endregion


	}
}
