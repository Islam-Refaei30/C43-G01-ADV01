namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = { 5, 3, 8, 1, 2 };

			Console.WriteLine($"Befor:\n");
			foreach (int i in numbers)
			{
				Console.Write(i+" ");
			}
	

			Helper<int>.BubbleSort(ref numbers);

			Console.WriteLine($"\n\nAfter:\n");
			foreach (int i in numbers) 
			{
				Console.Write(i+" ");
			}
		}
    }
}
