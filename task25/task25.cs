// Принимаем 2 числа (A и B)
// Возводим А в степень В через !! ЦИКЛ !!
// Выводим результат

Console.WriteLine("Данная программа возводит число А в натуральную степень В");

Console.Write("Введите число А: ");
int num = Convert.ToInt32(Console.ReadLine()); // Число с которым мы будем проводить операции

Console.Write("Введите число B: "); // Натуральная степень числа
int powNum = Convert.ToInt32(Console.ReadLine());

int iter = powNum; // Количество итераций

int res = num; // Коробка куда будут складываться значения

int index = 0; 

for (index = 0; index < iter - 1; index++) // Цикл
{
    res = res * num; // Сама операция
}

Console.Write("Ответ: " + res); // Вывод на экран

//Протестировал