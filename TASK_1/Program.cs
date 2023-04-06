Console.WriteLine("Введите пятизначное число для проверки");

int number = int.Parse(Console.ReadLine());

if(number < 0)
{
number = number * -1;
}

if (number > 9999 && number < 100000)
{

    int a = number / 10000 % 10;
    int b = number / 1000 % 10;
    int c = number / 10 % 10;
    int d = number % 10;
    if (a == d && b==c) Console.WriteLine("палиндром");
    else Console.WriteLine("не палиндром");

}
else Console.WriteLine("Введите пятизначное число!");

