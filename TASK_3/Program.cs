int number = int.Parse(Console.ReadLine());

if (number > 5 && number < 8)
{
    Console.WriteLine("выходной");
}
else if (number >= 1 && number <= 5)
{
    Console.WriteLine("Будний");
}
else
{
    Console.WriteLine("Нет такого дня недели!");
}