
int[,] magicSquare = new int[,]
        {
            {17, 24,  1,  8, 15},
            {23,  5,  7, 14, 16},
            { 4,  6, 13, 20, 22},
            {10, 12, 19, 21,  3},
            {11, 18, 25,  2,  9}
        };
if (NumberUtils.MagicSquare(magicSquare))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
Console.WriteLine("Hello, World!");
Console.WriteLine();
NumberUtils.DrawCircle(5);
