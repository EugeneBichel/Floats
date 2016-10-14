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

			float f1 = 1.1f;
			float f2 = 1.05f + 0.05f;

			if(f1 == f2)
			{
				Console.WriteLine("f1({0:G9}) equals f2({1})", f1, f2);
			}
			else
			{
				Console.WriteLine("f1({0:G9}) does not equal f2({1})", f1, f2);
			}

			Console.ReadKey();

			float f3 = 1.1f;
			float f4 = f3;

			if(f3 == f4)
			{
				Console.WriteLine("f3 == f4 is {0}", f3 == f4);
			}
			else
			{
				Console.WriteLine("f3 == f4 is {0}", f3 == f4);
			}


			double d1 = 1.1;
			double d2 = (double)(float)d1;
			if (d1 == d2)
			{
				Console.WriteLine("d1 == d2 is {0}", d1 == d2);
			}
			else
			{
				Console.WriteLine("d1 is {0:G9}", d1);
				Console.WriteLine("d2 is {0:G9}", d2);
				Console.WriteLine("d1 == d2 is {0}", d1 == d2);
			}

			Console.ReadKey();
		}
	}
}
