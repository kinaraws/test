using System;

class SoalMasAdien
{
    private static int n;
    static void Main()
    { 
        CheckNumber();
        PrintNumber();
        Console.WriteLine("Thank you!");
    }

    private static void CheckNumber()
    {
        Console.WriteLine("Input n number");
        string userInput = Console.ReadLine();
        if (!int.TryParse(userInput, out n))
        {
            Console.WriteLine("Please insert correct number");
            CheckNumber();
        }
    }

    private static void PrintNumber()
    {
        for (int i = 1; i < n + 1; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("foobar, ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("foo, ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("bar, ");
            }
            else
            {
                Console.Write($"{i}, ");
            }

        }
        return;
    }
}