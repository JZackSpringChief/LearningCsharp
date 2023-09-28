using System;

public class Program
{
	static void Main(string[] args)
	{
		int x = 7;
		
		Console.WriteLine(x == 7);
		Console.WriteLine(x!=8);
		Console.WriteLine(x > 10);
		Console.WriteLine(x < 2);
		Console.WriteLine(x >= 7);
		Console.WriteLine(x <= 7);
	}
}

//fav state if
using System;

public class Program
{
	static void Main(string[] args)
	{
		int purchase = 1700;
		if (purchase>=1500)
		{
			Console.WriteLine("Discount!");
		}
	}
}

//if else 
using System;

public class Program
{
	static void Main(string[] args)
	{
		int score = 98;
		
		if(score >=100)
		{
			Console.WriteLine("Level Completed!");
		} 
		else
		{
			Console.WriteLine("Try again!");
		}
	}
}

// if else and if else. similar to js
using System;

public class Program
{
	static void Main(string[] args)
	{
		int time = 15;
		
		if(time<10)
		{
			Console.WriteLine("Good morning!");
		} 
		else if(time<20)
		{
			Console.WriteLine("Good day!");
		}
		else
		{
			Console.WriteLine("Good evening!");
		}
	}
}
