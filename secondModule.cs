using System;

public class Program
{
public static void Main(string[] args)
	{
		int balls = 100;
		int ballsInBox = 3;

		int result = balls%ballsInBox;

		Console.WriteLine(result);
	}
}

//'%' operator gets the remainder
//++ and -- can increment and decrement respectivly also x = 10 write like this(x++) will still be 10 however, written like this (++x) will become 11 same for decrement.
// assignment operators example int score = 10; score+=10; adds 10 in this ex. "+=" and "-="
// cont can use assignment operators with variables ex 
double price = 50;
double rate = 1.2;
price*=rate;

// user inpute Console.Readline to get info;
//type conversion; ex
string text = "5";
int number1 = Convert.ToInt32(text);
// cannot convert strings like "hello" to and int
//can conver to string using Convert.ToString(); method. as well as these. .ToBoolean, .ToChar, .ToDouble, .ToInt16, 32, 64 => converts to bit

//ex
using System;

public class Program
{
public static void Main(string[] args)
	{
		//taking inputs
		string input1 = Console.ReadLine();
		string input2 = Console.ReadLine();

		//converting to int
		int number1 = Convert.ToInt32(input1);
		int number2 = Convert.ToInt32(input2);

		//calculating the sum
		int result = number1 + number2;

		Console.WriteLine(result);
	}
}

//this way is more efficient
using System;

public class Program
{
public static void Main(string[] args)
	{
		/* taking the inputs and
		converting them to int */
		int number1 = Convert.ToInt32(Console.ReadLine());
		int number2 = Convert.ToInt32(Console.ReadLine());

		//calculating the sum
		int result = number1 + number2;

		Console.WriteLine(result);
	}
}// more on strings
// how to quote with "" in c#
using System;

public class Program
{
public static void Main(string[] args)
	{
		Console.WriteLine("He said \"I am back!\"");
	}
}

// if we want to break and run on seperate lines use the following
using System;

public class Program
{
public static void Main(string[] args)
	{

		Console.WriteLine("One\nTwo\nThree");
	}
}

// we can also us \t to denote a tab and for a verbatim string we use "@"

//using interpolated string ex
using System;

public class Program
{
public static void Main(string[] args)
	{
		string city = "London";
        string capital = "Ontario";

		Console.WriteLine($"{city} is the capital of the United Kingdom. and the capital is{capital}");
	}
}

//comparison operators
