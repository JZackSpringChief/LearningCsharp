//Methods
using system;

static void Login()
[
    Console.WriteLine("Login");
]

//calling a method.

public class Program
{
	static void Main(string[] args)
	{
		Welcome();
	}
	static void Welcome() 
	{
		Console.WriteLine("Welcome");
		Console.WriteLine("I am a method");
		Console.WriteLine("End of method");
        //this is inside the scope.
	}
}

//main method is the entry point of the program, we call our method inside the scope.

//parameters and arguments

using System;

public class Program
{
	static void Main(string[] args)
	{
        //the values passed as parameters are called arguments.
		Welcome("John");
		Welcome("Tom");
	}
	static void Welcome(string name) 
	{
		Console.WriteLine("Welcome " + name);
	}
}

//multiple parameters. 


static void Welcome(string name, int age) 
{
    Console.WriteLine("Welcome " + name);
    Console.WriteLine("Your age: " + age);
}

using System;

public class Program
{
	static void Main(string[] args)
	{
		Welcome("John", 25);
		Welcome("Tom", 36);
	}
	static void Welcome(string name, int age) 
	{
		Console.WriteLine("Welcome " + name);
		Console.WriteLine("You age: " + age);
	}
}

static void Main(string[] args)
{
    int x = 8;
    int y = 17
    Sum(x, y)
}
static void Sum(int a, int b)
{
    Console.WriteLine(a + b);
}

using System;

public class Program
{
	static void Main(string[] args)
	{
		Perc(640,24);
	}
	static void Perc(double num, int percentage)
	{
		double res = num*percentage/100;
		Console.WriteLine(res);
	}
}

using System;

public class Program
{
	static void Main(string[] args)
	{
		Discount("Tom", 1700);
		Discount("Bob", 1300);
	}
	static void Discount(string name, double purchase)
	{
		if(purchase>=1500)
		{
			purchase*=0.85;
		}

		Console.WriteLine($"Customer: {name}");
		Console.WriteLine($"Total: {purchase}");
	}
}


using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Run(number);
    }

    //complete the method
    /*
    1. Shooter
    2. Puzzle
    3. Snake
    */
    static void Run(int num)
    {
    	// if(num == 1)
    	// {
    	// 	Console.WriteLine("Shooter");
    	// }
    	// else if (num == 2)
    	// {
    	// 	Console.WriteLine("Puzzle");
    	// }
    	// else if (num == 3)
    	// {
    	// 	Console.WriteLine("Snake");
    	// }
        switch(num)
            case 1:
            Console.WriteLine("Shooter");
            break;
            case 2:
            Console.WriteLine("Puzzle");
            break;
            case 3:
            Console.WriteLine("Snake");
            break;
            
    }
 
}

//switch to case statemnt

//sept28