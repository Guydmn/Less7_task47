// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите длинну массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] doubleArray = new double [m, n];
Random rnd = new Random();

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        doubleArray[i, j] = Math.Round(rnd.Next(-100, 101)*1.11, 2);
        Console.Write($"{doubleArray[i, j]} ");
    }
    Console.WriteLine();
}
