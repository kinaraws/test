using System;

class SoalMasAdien
{   
    static void CheckNumber()
    static void Main()
    {
        Console.WriteLine("Please input number");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Number Saved");
        }
        else
        {
            Console.WriteLine("Wrong numbera");
        }
    }
}