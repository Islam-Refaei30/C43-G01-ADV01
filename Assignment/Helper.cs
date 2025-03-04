using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
	internal class Helper<T> where T : IComparable<T>
	{
		public static void SWAP<T>(ref T x, ref T y) 
		{
			T temp = x;
			x = y;
			y = temp;
		}

		public static void BubbleSort(ref T[] array)
		{
			if (array is not null)
			{
				bool swapped;
				for (int i = 0; i < array.Length - 1; i++)
				{
					swapped = false;
					for (int j = 0; j < array.Length - i - 1; j++)
					{
						if (array[j].CompareTo(array[j + 1]) > 0)
						{
							SWAP(ref array[j], ref array[j + 1]);
							swapped = true; 
						}
					}

					if (!swapped)
						break;
				}
			}
		}


	}
}
