using System;
public class Program
{ 
    //global variables

    public static string[] userInput= {"0", "0", "0",};
    public static int[] userGrades= {0, 0, 0,};
    public static int userAverage = 0;

	public static void Main()
	{
		Console.WriteLine("Please type in 3 grades, 1 at a time, press enter with each number");
        for (int i =0; i>3; i++)

            {//ask 3 grades and save in array
                Console.WriteLine("Enter grade");
                userInput[i] = Console.ReadLine();
            }//end for loop


            Console.WriteLine(userInput[0]); //print 1
            Console.WriteLine(userInput[1]);//2
            Console.WriteLine(userInput[2]);//3



Console.WriteLine($" The grades you have entered are {userInput[1]}, {userInput[2]}, {userInput[3]},");


// I had an idea to do this in swoop and the internet said yes use this method 
// Converts the entire array in one line
userGrades = Array.ConvertAll(userInput, int.Parse);
//do average
userAverage = (userInput[1] + userInput[2] + userInput[3])/3;

Console.WriteLine($" Your grade average based on this total is {userAverage}");
    
	}
}

