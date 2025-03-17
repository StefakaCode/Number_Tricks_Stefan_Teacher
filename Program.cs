// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.Write("n: ");
int n = int.Parse(Console.ReadLine());

int[][] pascalTriangle = NumberUtils.GeneratePascalTriangle(n);
foreach (var row in pascalTriangle)
{
    Console.WriteLine(string.Join(" ", row));
}
