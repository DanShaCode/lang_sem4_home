// Принимаем 2 числа (A и B)
// Возводим А в степень В

Console.WriteLine("Данная программа возводит число А в натуральную степень В");
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

double res = Math.Pow(numA, numB);

Console.WriteLine("Ответ: " + res);