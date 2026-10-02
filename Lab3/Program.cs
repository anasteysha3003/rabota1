Console.WriteLine("Hello, World!");//Лабораторная работа 2.2
try
{
    Console.Write("Введите двухзначное число m:");
    int m = int.Parse(Console.ReadLine());
    int e = m % 10;
    int d = m / 10;
    Console.Write("a)");
    if ((e == 3) || (d == 3) && (e == 7) || (d == 7))
        Console.WriteLine("да, входят");
    else Console.WriteLine("нет, не входят");
    Console.Write("б)");
    if ((((e == 4) || (d == 4)) && ((e == 8) || (d == 8))) || ((e == 9) || (d == 9)))
        Console.WriteLine("да, вхадят");
    else Console.WriteLine("нет, не входят");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}