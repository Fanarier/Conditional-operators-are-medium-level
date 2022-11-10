//Ввести с клавиатуры три целых числа (длины сторон треугольника).Определить, возможно, ли построить по этим числам треугольник. Ответ вывести в виде сообщения.
//2.2. №варианта:16,  Оператор выбора вариантов. Плотников Кирилл Андреевич 22-ИСП-2/2
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Введите A:");
Double A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите B:");
Double B = double.Parse(Console.ReadLine());
Console.WriteLine("Введите C:");
Double C = double.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Yellow;

if ((A + B > C) & (A + C > B) & (B + C > A)) Console.WriteLine("Можно");
else Console.WriteLine("Нельзя");

Console.ForegroundColor = ConsoleColor.White;