int number = int.Parse(Console.ReadLine());

int n;

for (n = 1; n <= number; n++)
{
    Console.Write(Math.Pow(n, 3) + " ");
}