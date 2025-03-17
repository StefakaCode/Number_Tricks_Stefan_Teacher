using System;

public class NumberUtils
{
	public static double Babylon(float n)
	{
        float x = n;
        float y = 1;
        double e = 0.000001;
        while (x - y > e)
        {
            x = (x + y) / 2;
            y = n / x;
        }
        return x;
    }
  
    public static List<int> FindDivisors(int n)
    {
        List<int> divisors = new List<int>();

        for (int i = 1; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                divisors.Add(i);
                if (i != n / i)
                {
                    divisors.Add(n / i);
                }
            }
        }
        divisors.Sort();
        return divisors;
    }
        
    public static double FastExponentiate(double a, int power)
    {
        if (power == 0) return 1;
        double halfPowered = FastExponentiate(a, power / 2);
        double subTotal = halfPowered * halfPowered;
        return power % 2 == 0 ? subTotal : subTotal * a;

    }

    public static void DrawCircle(double r)
    {
        int bound = (int)Math.Ceiling(r);
        for (int y = bound-1; y >= -bound; y--)
        {
            for (int x = -bound; x < bound; x++)
            {
                bool isInCircle = x * x + y * y < r * r;
                Console.Write(isInCircle ? "##": "  ");
            }
            Console.WriteLine();
        }
    }
}
