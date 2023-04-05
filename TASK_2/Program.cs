double[] a = { 0, 0, 0 };
double[] b = { 0, 0, 0 };

void FillingArray(double[] name)
{
    int i;
    for (i = 0; i < name.Length; i++)
    {
        name[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("first coordinate x,y,z");
FillingArray(a);
Console.WriteLine("second coordinate x,y,z");
FillingArray(b);

double distance = Math.Sqrt((Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2)));

Console.WriteLine("distance = " + (string.Format("{0:F2}", distance)));