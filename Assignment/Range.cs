using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
	internal class Range<T> where T : IComparable<T>
	{
		public T Min { get; private set; }
		public T Max { get; private set; }

		public Range(T min, T max)
		{
			if (min.CompareTo(max) > 0)
			{
				Max = min;
				Min = max;
			}
			else
			{
				Min = min;
				Max = max;
			}
		}

		public bool IsInRange(T value)
		{
			if (value is not null)
			return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
			return false;
		}

		public dynamic Length()
		{
			try
			{
				return (dynamic)Max - (dynamic)Min;
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Operation not supported for type {typeof(T)}", ex);
			}
		}
	}
}
