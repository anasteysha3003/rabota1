//Console.WriteLine("Hello, World!");//Лабораторная работа 2.2
//try
//{
//    Console.Write("Введите двухзначное число m:");
//    int m = int.Parse(Console.ReadLine());
//    int e = m % 10;
//    int d = m / 10;
//    Console.Write("a)");
//    if ((e == 3) || (d == 3) && (e == 7) || (d == 7))
//        Console.WriteLine("да, входят");
//    else Console.WriteLine("нет, не входят");
//    Console.Write("б)");
//    if ((((e == 4) || (d == 4)) && ((e == 8) || (d == 8))) || ((e == 9) || (d == 9)))
//        Console.WriteLine("да, вхадят");
//    else Console.WriteLine("нет, не входят");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Лабораторная работа 2.3
//try
//{
//    Console.Write("введите номер задания:");
//    int k = int.Parse(Console.ReadLine());
//    Console.Write("введите переменную x");
//    double x = double.Parse(Console.ReadLine());
//    double y=0;
//    switch (k)
//    {
//        case 1:
//            {
//                double b = -1.6, m = 0.9, n = -1.4;
//                if (Math.Abs(b * m) > x * x) Console.WriteLine($" {y} = {Math.Sin(b * m + Math.Cos(n * x))}");
//                else if (Math.Abs(b * m) < x * x) Console.WriteLine($"{y} = {Math.Cos(b * m - Math.Sin(x))}");
//                else if (Math.Abs(b * m) == x * x) Console.WriteLine($"{y} = {Math.Sqrt(Math.Pow(Math.E, (Math.Abs(Math.Cos(x)))) + Math.Sqrt(Math.Abs(b * m * x)))}");
//            }
//            break;
//        case 2:
//            {
//                double b = 4.5, m = -2, n = 2.2;
//                if (Math.Abs(b * m) > x * x) Console.WriteLine($" {y} = {Math.Sin(b * m + Math.Cos(n * x))}");
//                else if (Math.Abs(b * m) < x * x) Console.WriteLine($"{y} = {Math.Cos(b * m - Math.Sin(x))}");
//                else if (Math.Abs(b * m) == x * x) Console.WriteLine($"{y} = {Math.Sqrt(Math.Pow(Math.E, (Math.Abs(Math.Cos(x)))) + Math.Sqrt(Math.Abs(b * m * x)))}");
//            }
//            break;
//        case 3:
//            {
//                double b = -4.5, m = 0.5, n = -1.5;
//                if (Math.Abs(b * m) > x * x) Console.WriteLine($" {y} = {Math.Sin(b * m + Math.Cos(n * x))}");
//                else if (Math.Abs(b * m) < x * x) Console.WriteLine($"{y} = {Math.Cos(b * m - Math.Sin(x))}");
//                else if (Math.Abs(b * m) == x * x) Console.WriteLine($"{y} = {Math.Sqrt(Math.Pow(Math.E, (Math.Abs(Math.Cos(x)))) + Math.Sqrt(Math.Abs(b * m * x)))}");
//            }
//            break;
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}