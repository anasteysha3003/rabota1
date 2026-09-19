//Console.Write("Введите ваше имя:");
//string name = Console.ReadLine();
//Console.WriteLine("Меня зовут" + name);
//Console.WriteLine("Меня зовут {0} ",name);
//Console.WriteLine($"Меня зовут {name}");

//Console.Write("Введите х:");
//int x = int.Parse(Console.ReadLine());
//Console.Write("Введите у:");
//int y = int.Parse(Console.ReadLine());
//int s = y + x;
//Console.WriteLine($"{x}+{y}={s}");

//Console.Write("Введите угол в градусах:");
//double angle = double.Parse(Console.ReadLine());
//double y = Math.Sin(angle*Math.PI/180);
//Console.WriteLine($"y={y:F2}");

//Console.Write("Введите степень числа:");
//double number = double.Parse(Console.ReadLine());
//double y = Math.Exp(7*number);
//Console.WriteLine($"y={y:f2}");

//Console.WriteLine($"{Math.PI:f2}");

//Console.WriteLine($"{Math.E:f1}");

//Console.Write("Введите число а:");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {a}");

//Console.WriteLine("1 13 49");
//Console.WriteLine("7  15  100");

//try
//{
//    Console.Write("Введите а:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите в:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    double d = ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
//    Console.WriteLine($"{d:f2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//1
//try
//{
//    Console.Write("Введите расстояние в см:");
//    int sm = int.Parse(Console.ReadLine());
//    int m = sm / 100;
//    Console.WriteLine($"Полных метров:{m}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//2
//Console.Write("Введите массу в кг:");
//int kg = int.Parse(Console.ReadLine());
//int ct = kg / 100;
//Console.WriteLine($"Полных центнеров:{ct}");
//3
//Console.Write("Введите массу в кг:");
//int kg = int.Parse(Console.ReadLine());
//int t = kg / 1000;
//Console.WriteLine($"Полных тонн:{t}");
//4
//Console.Write("Введите расстояние в метрах:");
//int m = int.Parse(Console.ReadLine());
//int km = m / 1000;
//Console.WriteLine($"Полных километров:{km}");
//5
//Console.Write("С некоторого момента прошло 234 дня, значит ");
//int n = 234 / 7;
//Console.WriteLine($"Полных недель:{n}");
//6
//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//int hour = n / 3600;
//int minute = (n % 3600) / 60;
//int second =  n % 60;
//Console.WriteLine($"а)Полных часов с начала суток: {hour}");
//Console.WriteLine($"б)Полных минут с начала очередного часа: {minute}");
//Console.WriteLine($"в)Полных секунд с начала очередной минуты: {second}");
7
//Console.Write("прямоугльник размерами 543 на 130 мм можно разделить на ");
//int nk = (543 * 130) / (130 * 130);
//Console.WriteLine($"{nk} квадрата.");
//8
//try 
//{ 
//Console.Write("Введите четырехзначное число: ");
//int n = int.Parse(Console.ReadLine());
//int e = n % 10;
//int d = n % 100 / 10;
//int s = n % 1000 / 100;
//int t = n / 1000;
//int sum = e + d + s + t;
//Console.WriteLine ($"колличество едениц: {e}");
//Console.WriteLine($"колличество десятков: {d}");
//Console.WriteLine($"колличество сотен: {s}");
//Console.WriteLine($"колличество тысяч: {t}");
//Console.WriteLine($"сумма цифр числа: {sum}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
