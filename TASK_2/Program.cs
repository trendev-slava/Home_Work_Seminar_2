
//Функция для возведения 10 в необходимую степень
int Stepen(int step)
{
    int i;
    int res = 1;
    for (i = 1; i <= step; i++)
    {
        res = 10 * res;
    }
    return res;
}

int number = int.Parse(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int i = 10;
    int step = -2;

    //Определяю количество знаков в числе и необходимую степень
    while (number / i != 0)
    {
        i = i * 10;
        step++;
    }
    //Нахожу третий знак в числе
    int res = ((number % i) % (i / 100)) / Stepen(step);

    Console.WriteLine(res);
}
