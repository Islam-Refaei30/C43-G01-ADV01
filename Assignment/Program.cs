namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Q1
			//int[] numbers = { 5, 3, 8, 1, 2 };

			//Console.WriteLine($"Befor:\n");
			//foreach (int i in numbers)
			//{
			//	Console.Write(i + " ");
			//}


			//Helper<int>.BubbleSort(ref numbers);

			//Console.WriteLine($"\n\nAfter:\n");
			//foreach (int i in numbers)
			//{
			//	Console.Write(i + " ");
			//}
			#endregion

			#region Q2
			var Range = new Range<int>(60, 60);
			Console.WriteLine($"15 in rand? {Range.IsInRange(15)}");
			Console.WriteLine($"Length =  {Range.Length()}");

			#endregion


		}
    }
}
