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

using System;

public class Program
{
	static void Main(string[] args)
	{
		string country = "US";
		int age = 42;

		if ((country == "US" || country == "GB") &&(age >0 && age <=100))
		{
			Console.WriteLine("Welcome!");
		}
	}
}

// Explore the countries 
//   
// You're a tour manager and need a program that will identify small countries.
// A country is considered small if its population is under 10000 and its area is under 10000 hectares. 
// The given code takes population and area from as input. 
//   
// Task: 
// Complete the code to output "small country" if both conditions are met. Don't output anything otherwise. 
//   
// Input Example 
// 9955 
// 7522 
//   
// Output Example 
// small country

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int population = Convert.ToInt32(Console.ReadLine());
        int area = Convert.ToInt32(Console.ReadLine());
        
        //your code goes here
        	
        	if (population < 10000 && area < 10000)
        	{
        		Console.WriteLine("small country");
        	}
        
        
    }
}

using System;

public class Program
{
	static void Main(string[] args)
	{
		int choice = 2;

		if(choice==1)
		{
			Console.WriteLine("Sports");
		}
		else if(choice==2)
		{
			Console.WriteLine("Business");
		}
		else if(choice==3)
		{
			Console.WriteLine("Technology");
		}
	}
}

//switch statements

using System;

public class Program
{
  static void Main(string[] args)
	{
	  int choice = 2;

	  switch(choice)
	  {
		case 1:
		  Console.WriteLine("Sports");
		  break;
			
		case 2:
		  //match!
		  Console.WriteLine("Business");
		  break;

		case 3:
		  Console.WriteLine("Technology");
		  break;			
	  }
  }
}

//if there is no proper input we add a default at the end of the switch case; ex
using System;

public class Program
{
	static void Main(string[] args)
	{
		string color = "yellow";
		switch(color)
		{
		  case "blue": 
			Console.WriteLine("This is blue.");
			break;
		  case "red": 
			Console.WriteLine("This is red.");
			break;
		  default: 
			Console.WriteLine("Color not found.");
			break;
		}
	}
}

// the ternary operator syntax example variable = condition ? expression1:expression2 ex
using System;

public class Program
{
	static void Main(string[] args)
	{
		int age = 42;
		string isAdult = age<18 ? "Too young": "Old enough";

		Console.WriteLine(isAdult);
	}
}

using System;

public class Program
{
	static void Main(string[] args)
	{
		double bill = 1800;
		bill = bill>=1500 ? bill * 0.85 : bill;

		Console.WriteLine(bill);
	}
}

// Guess the word! 
 
// Let’s write a program for a guessing game! The program takes the hidden word and the attempted 
//word as input and declares a variable for the result. 
// The player wins if the values are equal. 
//   
// Task 
// Complete the code to output "You win" if the word is guessed, and "You lose" if it's not. 
//   
// Input Example 
// Home 
// Roof 
//   
// Output Example 
// You lose

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string answer = Console.ReadLine();
        string attempt = Console.ReadLine();

        string result;
        result = answer == attempt ? "You win" : "You lose";

        Console.WriteLine(result);
    }
}