int number = int.Parse(Console.ReadLine());

if (number > 5 && number < 8)
{
    Console.WriteLine("Да");
}
else if (number >= 1 && number <= 5)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Нет такого дня недели!");
}