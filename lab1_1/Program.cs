//Console.Write("Введите х:");
//double x = double.Parse(Console.ReadLine());
//double K = (Math.Sqrt(Math.Pow(3 + x, 6) - Math.Log(x))) / (Math.Exp(0) + Math.Asin(6 * x * x));
//Console.WriteLine($"K={K:f2}");

Console.Write("Введите х:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите c:");
double c = double.Parse(Console.ReadLine());
double P = (Math.Pow(a, 5) + Math.Acos(a + Math.Pow(x, 3))) - (Math.Pow(Math.Sin(y-c),4)) / (Math.Pow(Math.Sin(x+y),3) + Math.Abs(x-y)) ;
Console.WriteLine($"P = {P:F2}");