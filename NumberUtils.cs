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

    public static int[] EratoshtenesSieve(int n)
    {
        bool[] isPrime = new bool[n]; // bool for each number from 1 to n
        for (int i = 1; i < n; i++) // i=0 would be for the number one, but one is not prime
            isPrime[i] = true;


        //from 2 to n
        for (int i = 1; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (isPrime[j] && (j + 1) % (i + 1) == 0)
                    isPrime[j] = false;

        int[] primes = isPrime.Select((isPrime,i) => isPrime ? i+1: 0 ).Where(n=>n!=0).ToArray();
        return primes;
    }
}
