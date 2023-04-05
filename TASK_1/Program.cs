void Palindrom(string array)
{
    int res = 1;
    int i;
    for (i = 0; i <= (array.Length / 2); i++)
    {
        if (array[i] != array[array.Length - i - 1])
        {
            Console.WriteLine("no");
            res = 0;
            break;
        }
    }
    if (res == 1) Console.WriteLine("yes");
}

Console.WriteLine("Input number: ");
string number = Console.ReadLine();
Palindrom(number);