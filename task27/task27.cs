// Принимаем число
// Выдаем сумму цифр в числе 
// Пример - 452 -> 11

Console.WriteLine("Данная программа принимает на вход число и выдает сумму цифр в числе");
Console.Write("Введите 2-х, 3-х или 4-хзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numCount = 0;

void Count (int num) // Считаем количество цифр в числе
{
    if (num < 0 | num > 0 && num < 10 | num > 9999) 
    {
        Console.WriteLine("Ошибка ввода.");
    }
    if (num > 9 && num < 100) numCount = 2; // 2 значные
    if (num > 99 && num < 1000) numCount = 3; //3 значные
    if (num > 999 && num < 10000) numCount = 4; // 4 значные 
}

void SplitNumSum(int num) // Разделям число на количество цифр и суммируем их
{
    if (numCount == 2)
    {
        int num1 = num / 10;
        int num2 = num % 10;
        int res = num1 + num2;
        Console.WriteLine("Сумма цифр в числе: " + res);
    }
    if (numCount == 3)
    {
        int num1 = num / 100;
        int num2 = (num / 10) % 10;
        int num3 = num % 10;
        int res = num1 + num2 + num3;
        Console.WriteLine("Сумма цифр в числе: " + res);

    }
    if (numCount == 4)
    {
        int num1 = num / 1000;
        int num2 = (num / 100) % 10;
        int num3 = (num / 10) % 10;
        int num4 = num % 10;
        int res = num1 + num2 + num3 + num4;
        Console.WriteLine("Сумма цифр в числе: " + res);
    }
}

Count(num);
SplitNumSum(num);