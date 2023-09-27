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