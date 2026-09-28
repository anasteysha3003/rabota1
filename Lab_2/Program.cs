try
{
    Console.Write("Введите х:");
    double x = double.Parse(Console.ReadLine());
    double y = (-(x * x) + 2);
    Console.WriteLine((y >= 0) && (y <= 2) && (x <= 1.5) && (x >= -1.5));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}