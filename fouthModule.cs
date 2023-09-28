//loops ex
using System;

public class Program
{
	static void Main(string[] args)
	{
		for(int i = 1; i <= 10; i++)
		{
			Console.WriteLine($"Value of i: {i}");
		}
	}
}

//this one would run only even number because it starts at and even number then we increment by  and even num; ex
using System;

public class Program
{
	static void Main(string[] args)
	{
		for(int i = 0; i <= 20; i+=2)
		{
			Console.WriteLine($"Value of i: {i}");
		}
	}
}

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        //your code goes here
		        for(int i=1; i<=number; i++)
        {
            if(i%2!=0)
            {
                Console.Write($"{i} ");
            }
        }
    }
}