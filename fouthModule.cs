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

using System;


//while loops
public class Program
{
	static void Main(string[] args)
	{
		int x = 5;

		while(x>0)
		{
			Console.WriteLine(x);
			x--;
		}
	}
}
//if condition is never false, the while loop will run forever


//adding numbers via loops
using System;

public class Program
{
	static void Main(string[] args)
	{
		int sum = 0;
		int num = 100;

		while(num>=0)
		{
			sum+=num;
			num--;
		}

		Console.WriteLine(sum);
	}
}

//do while loop will run once regardless if the condition is false. then run as a regular while loop. ex
using System;

public class Program
{
	static void Main(string[] args)
	{
		int i = 5;
		
		do
		{
			Console.WriteLine(i);
			i++;
		} while (i < 5);
	}
}

//for loops are the go to method

public class Program 
{
    public static void Main(string[] args)
    {
        int number Covert.ToInt32(Console.Readline());

        while(number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
    }
}
//break statments with loops
using System;

public class Program
{
	static void Main(string[] args)
	{
		for(int i = 0; i<=10; i++)
		{
			if(i==5)
			{
				break;
			}
			Console.WriteLine(i);
		}
	}
}

//break in while loop
using System;

public class Program
{
	static void Main(string[] args)
	{
		int num = 1;
		while(num<=10)
		{
			if(num == 3)
			{
				break;
			}
		Console.WriteLine(num);
		num++;
		}
	}
}

//continue statement used to skip an iteration of the loop and continue from the next one
using System;

public class Program
{
	static void Main(string[] args)
	{
		for(int i = 0; i<=10; i++)
		{
			if(i==5)
			{
				continue;
			}
			Console.WriteLine(i);
		}
	}
}

//modulus and divisable by 5
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int floors = Convert.ToInt32(Console.ReadLine());

        //your code goes here
        	for(int i = 1; i<=floors; i++)
        	{
        		if(i%5!=0)
        		{
        			continue;
        		}
        		Console.WriteLine(i);
        	}
        
    }
}

//sept 28