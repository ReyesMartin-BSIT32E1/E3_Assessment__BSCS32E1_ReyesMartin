using System;

class Class
{
	//first part
	static void Triangle_Area()
	{
		Console.Clear();
		Console.Write("Enter Base: ");
		float b = float.Parse(Console.ReadLine());
		Console.Write("Enter Height: ");
		float h = float.Parse(Console.ReadLine());
		Console.WriteLine("Triangle Area: " + b * h / 2);
		Console.ReadKey();
	}

	//second part
	static void Formula_Array()
	{
		//declare new array
		float[] array = new float[5];
		Console.Clear();
		Console.Write("Enter Starting Number: ");
		array[0] = float.Parse(Console.ReadLine());
		float max = array[0];
		Console.Write("Enter Operand: ");
		float n = float.Parse(Console.ReadLine());
		while (true)
		{
			//rewrite incase wrong operation input
			Console.Clear();
			Console.WriteLine("Enter Starting Number: " + array[0]);
			Console.WriteLine("Enter Operand: " + n);
			Console.Write("Enter Operation (+, -, *, /, ^): ");
			switch (Console.ReadLine())
			{
				case "+":
					for (int i = 1; i < 5; i++)
					{
						array[i] = array[i - 1] + n;
						if (array[i] > max)
							max = array[i];
					}
					Console.WriteLine("Array: " + string.Join(", ", array));
					Console.WriteLine("Largest Number: " + max);
					Console.ReadKey();
					return;
				case "-":
					for (int i = 1; i < 5; i++)
					{
						array[i] = array[i - 1] - n;
						if (array[i] > max)
							max = array[i];
					}
					Console.WriteLine("Array: " + string.Join(", ", array));
					Console.WriteLine("Largest Number: " + max);
					Console.ReadKey();
					return;
				case "*":
					for (int i = 1; i < 5; i++)
					{
						array[i] = array[i - 1] * n;
						if (array[i] > max)
							max = array[i];
					}
					Console.WriteLine("Array: " + string.Join(", ", array));
					Console.WriteLine("Largest Number: " + max);
					Console.ReadKey();
					return;
				case "/":
					for (int i = 1; i < 5; i++)
					{
						array[i] = array[i - 1] / n;
						if (array[i] > max)
							max = array[i];
					}
					Console.WriteLine("Array: " + string.Join(", ", array));
					Console.WriteLine("Largest Number: " + max);
					Console.ReadKey();
					return;
				case "^":
					for (int i = 1; i < 5; i++)
					{
						array[i] = (float)Math.Pow(array[i - 1], n);
						if (array[i] > max)
							max = array[i];
					}
					Console.WriteLine("Array: " + string.Join(", ", array));
					Console.WriteLine("Largest Number: " + max);
					Console.ReadKey();
					return;
				default:
					//loop back when operation is invalid
					break;
			}
		}
	}

	//third part
	static void Square_Root()
	{
		Console.Clear();
		for (float i = 1; i <= 10; i++)
		{
			Console.WriteLine("Number: " + i + ", Square Root: " + Math.Sqrt(i));
		}
		Console.ReadKey();
	}
	
	//main method
    static void Main(string[] args)
    {
		//select program
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select Program");
            Console.WriteLine("1 Triangle Area");
            Console.WriteLine("2 Formula Array");
            Console.WriteLine("3 Square Root");
            Console.WriteLine("4 Exit");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Triangle_Area();
                    break;
                case 2:
                    Formula_Array();
                    break;
                case 3:
                    Square_Root();
                    break;
                case 4:
					//exit
                    return;
                default:
                    break;
            }
        }
    }
}