// Задаем массив из 8 элементов 
// Выводим элементы массива на экран 

Console.Write("Введите количество элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] newArray = new int[arrayLength];

void FillArray (int[] userData)
{
    int length = userData.Length;
    int index = 0;
    Console.WriteLine("Теперь введите поочередно элементы массива: ");
    for (index = 0; index < userData.Length; index++)
    {
        userData[index] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray (int[] print)
{
    int length = print.Length;
    int index = 0;
    string space = " ";
    Console.Write("Полученный массив: ");
    for (index = 0; index < print.Length; index++)
    {
        Console.Write(print[index] + space);
    }
}

FillArray(newArray);
PrintArray(newArray);

//Протестировано