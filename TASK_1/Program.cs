int number = int.Parse(Console.ReadLine()!);

if (number >= 100 && number <1000)
{
    int res = (number % 100) / 10;
    Console.WriteLine(res);
}
else Console.WriteLine("не 3-ч значное");