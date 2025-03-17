using System;
using System.IO.IsolatedStorage;

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

    public static bool MagicSquare(int[,] square)
    {
        int firstRowSum = 0;
        int sum = 0;
        bool isMagic = true;
        for (int i = 0; i < square.GetLength(1); i++)
        {
            firstRowSum += square[1, i];
        }
        


            for (int i = 0; i < square.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    sum += square[i, j];
                }
                if (!(sum == firstRowSum))
                {
                    isMagic = false;
                }
            }
            for (int i = 0; i < square.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    sum += square[j, i];
                }
                if (!(sum == firstRowSum))
                {
                isMagic = false;
                }
                

            }
        
        return isMagic;
    }

    public static int[] EratoshtenesSieve(int n)
    {
        bool[] isPrime = new bool[n]; // bool for each number from 1 to n
        for (int i = 0; i < n; i++) // start with all true by default
            isPrime[i] = true;
        
        isPrime[0] = false; // one is not prime by definition

        // for numbers from 2 to n
        for (int i = 1; i < n; i++)
            for (int j = i + 1; j < n; j++)
                // if current number is a multiple of a previous number
                if ((j + 1) % (i + 1) == 0) 
                    isPrime[j] = false;

        // convert bools to ints and only keep those which are prime
        int[] primes = isPrime.Select((_, i) => i + 1)
            .Where((_, i) => isPrime[i]).ToArray();
        return primes;
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
