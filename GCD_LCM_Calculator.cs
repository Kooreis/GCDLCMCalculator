```CSharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, gcd, lcm;
        Console.Write("Enter the First Number : ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number : ");
        num2 = int.Parse(Console.ReadLine());
        gcd = GCD(num1, num2);
        lcm = LCM(num1, num2);
        Console.WriteLine("GCD of {0} and {1} is {2}", num1, num2, gcd);
        Console.WriteLine("LCM of {0} and {1} is {2}", num1, num2, lcm);
        Console.ReadLine();
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }

    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }
}
```