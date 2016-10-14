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

			float zero = 0;
			float one = 1;
			float minusOne = -1;

			checked
			{
				Console.WriteLine("0/0 = {0}", zero/zero);
				Console.WriteLine("1/0 = {0}", one / zero);
				Console.WriteLine("-1/0 = {0}", minusOne / zero);

				float infinity = one / zero;
				Console.WriteLine("1 / infinity = {0}", one / infinity);
				Console.WriteLine("-1 / infinity = {0}", minusOne / infinity);
				Console.WriteLine("0 / infinity = {0}", zero / infinity);
				Console.WriteLine("infinity / infinity = {0}", infinity / infinity);
			}

			Console.ReadKey();
		}
	}
}
