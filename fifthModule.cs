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
        //parameters
		Welcome("John");
		Welcome("Tom");
	}
	static void Welcome(string name) 
	{
		Console.WriteLine("Welcome " + name);
	}
}

//sept28