using System;

public class NumberUtils
{
    public NumberUtils()
    {

    }
    public static int[][] GeneratePascalTriangle(int n)
    { 
        int[][] triangle = new int[n][];

        for (int i = 0; i < n; i++)
        {
            triangle[i] = new int[i + 1]; 
            triangle[i][0] = 1;
            triangle[i][i] = 1; 

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        return triangle;
    }
    public static double FastExponentiate(double a, int power)
    {
        if (power == 0) return 1;
        double halfPowered = FastExponentiate(a, power / 2);
        double subTotal = halfPowered * halfPowered;
        return power % 2 == 0 ? subTotal : subTotal * a;

    }
}
