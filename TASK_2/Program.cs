double[] a = { 0, 0, 0 };
double[] b = { 0, 0, 0 };

double[] InputDotCoordinate()
{
    
}

Console.WriteLine("first dot coordinate");

Console.Write("x: ");
a[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
a[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
a[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("second dot coordinate");

Console.Write("x: ");
b[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
b[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
b[2] = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2)));

Console.WriteLine("distance = " + (string.Format("{0:F2}", distance)));