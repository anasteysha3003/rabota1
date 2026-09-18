//Console.Write("Введите х:");
//double x = double.Parse(Console.ReadLine());
//double K = (Math.Sqrt(Math.Pow(3 + x, 6) - Math.Log(x))) / (Math.Exp(0) + Math.Asin(6 * x * x));
//Console.WriteLine($"K={K:f2}");

//Лабораторная работа 1.1
//Console.Write("Введите х:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите c:");
//double c = double.Parse(Console.ReadLine());
//double P = (Math.Pow(a, 5) + Math.Acos(a + Math.Pow(x, 3))) - (Math.Pow(Math.Sin(y-c),4)) / (Math.Pow(Math.Sin(x+y),3) + Math.Abs(x-y)) ;
//Console.WriteLine($"P = {P:F2}");

//Лабораторная работа 1.2
Console.Write("Введите число сторон n:");
double n = double.Parse(Console.ReadLine());
Console.Write("Введите длинну стороны а:");
double a  = double.Parse(Console.ReadLine());
double R = a / (2 * Math.Sin(Math.PI / n));
double r = a / (Math.Tan(Math.PI / n));
Console.WriteLine($"R = {R:f2}");
Console.WriteLine($"r = {r:f2}");
