using System;

public class Program
{
	public static void Main(string[] args)
	{
		while (true)
		{
			Run();
		}
	}

	public static int Sum(int firstNumber, int secondNumber)
	{
		return firstNumber + secondNumber;
	}
	public static int Min(int firstNumber, int secondNumber)
	{
		return firstNumber - secondNumber;
	}
	public static int Mul(int firstNumber, int secondNumber)
	{
		return firstNumber * secondNumber;
	}
	public static int Div(int firstNumber, int secondNumber)
	{
		return firstNumber * secondNumber;
	}
	
	public static int Calc(int firstNumber, int secondNumber, string symbol)
	{
		if (symbol == "+")
			return Sum(firstNumber, secondNumber);
		if (symbol == "-")
			return Min(firstNumber, secondNumber);
		if (symbol == "*")
			return Mul(firstNumber, secondNumber);
		if (symbol == ":")
			return Div(firstNumber, secondNumber);

		return 0;
	}

	public static void RunCalc()
	{
		int firstNumber = int.Parse(Console.ReadLine());
		int secondNumber = int.Parse(Console.ReadLine());

		string symbol = Console.ReadLine();

		Console.WriteLine(Calc(firstNumber, secondNumber, symbol));
	}

	public static void WriteSquare(int width, int height)
	{
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				Console.Write("+");
			}

			Console.WriteLine();
		}
	}

	public static void WriteTriangle(int width, int height)
	{
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				Console.Write("+");
			}

			Console.WriteLine();
			height--;
		}
	}

	public static void RunShapeWriter()
	{
		int width = int.Parse(Console.ReadLine());
		int height = int.Parse(Console.ReadLine());

		string shape = Console.ReadLine();

		if (shape == "Square")
		{
			WriteSquare(width, height);
			return;
		}
		if (shape == "Triangle")
		{
			WriteTriangle(width, height);
			return;
		}
		Console.WriteLine("Wrong shape");
	}

	public static void Run()
	{
		string type = Console.ReadLine();

		if (type == "Calc")
		{
			RunCalc();
			return;
		}
		if (type == "ShapeWriter")
		{
			RunShapeWriter();
			return;
		}
		Console.WriteLine("Not correct type");
	}
}
