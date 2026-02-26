using System;
public class Program
{ 
    //global variables

    public static string[] userInput= {0, 0, 0,};
    public static string[] userGrades= {0, 0, 0,};

	public static void Main()
	{
		Console.WriteLine("Please type in 3 grades, 1 at a time, press enter with each number");
        for (int i =0; i>3; i++)

            {
                Console.WriteLine("Enter grade");
                userInput[i] = Console.WriteLine();
            }

//ask 3 grades and save in array

//end for loop




//print grades they gave using {userInput[0]} 0, 1, and 2
Console.WriteLine($" The grades you have entered are {userInput[1]}, {userInput[2]}, {userInput[3]},");

//do average

// console write line print average

	}
}

