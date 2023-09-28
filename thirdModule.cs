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

//logical operators "&&" ex. need both conditions to be true in order to be true
using System;

public class Program
{
	static void Main(string[] args)
	{
		int points = 95;
		int keys = 2;

		if(points>=90 && keys >=2)
		{
			Console.WriteLine("Level Completed!");
		}
		else
		{
			Console.WriteLine("Try again!");
		}
	}
}

//logical or "||" operator only requires one condition to be true
using System;

public class Program
{
	static void Main(string[] args)
	{
		int hour = 18;
		string day = "Sunday";

		if(hour>20 || day=="Sunday")
		{
			Console.WriteLine("Closed");
		}
		else
		{
			Console.WriteLine("Opened");
		}
	}
}

//the not "!" operator reverses a logical state !true is false; ex.
using System;

public class Program
{
	static void Main(string[] args)
	{
		string day = "Monday";

		if( !(day=="Sunday"))
		{
			Console.WriteLine("Working day");
		}
		else
		{
			Console.WriteLine("Non-working day");
		}
	}
}