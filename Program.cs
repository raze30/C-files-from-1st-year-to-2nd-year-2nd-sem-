using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program 
{         
    public static void Main()
    {	
	    Console.Write("Input your Average Grade: ");
        double grade = 75;
		grade = Convert.ToDouble(Console.ReadLine());
		
		
		if (grade >= 75)
		{
          Console.WriteLine("");
          Console.WriteLine("REMARKS: PASSED");
		  Console.WriteLine("Yeyy! You passed, brother.");
		}
		
		
		if (grade < 75 && grade > 65)
		{
           Console.WriteLine("");
           Console.WriteLine("REMARKS: FAILED");
		   Console.WriteLine("Oh No! You failed, brother. More improvements next time :>");
        }
		
		if (grade <= 65)
		{
            Console.WriteLine("");
			Console.WriteLine("REMARKS: INC");
			Console.WriteLine("Brother, you need to comply on your subjects.");
		}
    }
}
