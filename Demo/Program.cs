namespace Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Part 01 Swap Example

			#region Befor Genenrics
			//int A = 5, B = 8;
			//double A = 55, B = 88;
			//Console.WriteLine($"A = {A}, B = {B} Befor Swap");
			//Helper.SWAP(ref A, ref B);
			//Console.WriteLine($"A = {A}, B = {B} After Swap");

			//Point p1 = new Point(50, 30);
			//Point p2 = new Point(20, 10);

			//object p1 = new Point(50, 30);
			//object p2 = new Point(20, 10);

			//Console.WriteLine($"{p1}\n{p2}\nBefor Swap\n");
			//Helper.SWAP(ref p1, ref p2);
			//Console.WriteLine($"{p1}\n{p2}\nAfter Swap");
			#endregion

			#region After Genenrics
			//int A = 5, B = 8;
			//double A = 55, B = 88;

			//Console.WriteLine($"A = {A}, B = {B} Befor Swap");
			//Helper.SWAP<double>(ref A, ref B);
			//Console.WriteLine($"A = {A}, B = {B} After Swap");

			//Point p1 = new Point(50, 30);
			//Point p2 = new Point(20, 10);

			//object p1 = new Point(50, 30);
			//object p2 = new Point(20, 10);

			//Console.WriteLine($"{p1}\n{p2}\nBefor Swap\n");
			//Helper.SWAP(ref p1, ref p2);
			//Console.WriteLine($"{p1}\n{p2}\nAfter Swap");
			#endregion

			#endregion
		}
	}
}
