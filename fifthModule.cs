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
//sept28