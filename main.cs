using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int integer;
        var integervalue = 0;
        var answer = 0;

        Console.WriteLine("Please enter an integer");
        Console.WriteLine("");

        Console.Write("integer: ");
        integer = Convert.ToInt32(Console.ReadLine());

        if (integer >= 0)
        {
            for (let count = 0; count < integer; count++)
            {
                integervalue++;
                answer = answer + integervalue;
            }
        }
        else
        {
            for (let count = 0; count > integer; count--)
            {
                integervalue--;
                answer = answer + integervalue;
            }
        }

        Console.WriteLine(answer);

        Console.WriteLine("\nDone.");
    }
}