using System;

namespace FloatsApproximate
{
	class Program
	{
		static void Main(string[] args)
		{
			double num1 = 1.4; // 7/5 can not represent exactly in binary
			double num2 = 1.25; // we can present it exaclty in binary as 5/4 = 0.01+0.01+0.01+0.01+0.01

			Console.WriteLine("1.4 is stored as {0:G20}", num1);
			Console.WriteLine("1.25 is stored as {0:G20}", num2);

			Console.ReadKey();
		}
	}
}
