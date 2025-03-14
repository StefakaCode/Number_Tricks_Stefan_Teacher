﻿using System;

public class NumberUtils
{
	public NumberUtils()
	{

	}
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
}
