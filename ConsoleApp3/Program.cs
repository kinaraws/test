using System;

class SoalMasAdien
{
    static void Main()
    {
        Console.WriteLine("Input n number");
        int n = Int32.Parse(Console.ReadLine());
        int.TryParse(Console.ReadLine(), out n);
        for (int i = 1; i < n+1; i++) 
        {
            if (i%3==0 && i%5==0)
            {
                Console.Write("foobar, ");
            } else if (i%3==0)
            {
                Console.Write("foo, ");
            } else if (i % 5 ==0)
            {
                Console.Write("bar, ");
            }
            else
            {
                Console.Write($"{i}, ");
            }
        }
    }
}