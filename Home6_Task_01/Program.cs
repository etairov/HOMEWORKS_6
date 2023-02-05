//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//вводим через один Enter (разбиваем через Split())
//-------------------------------------------------- (НЕ ЗАКОНЧЕНО!!!)


int GetNumber()
{
    int[] array = new int[5];
    int i = 0;

    for (i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите любое число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
    return array[i];
}
//--------------------------------
void CheckParity(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
         if (arr[i] > 0) count++;
    }
    Console.Write($"Количество четных чисел -> {count}");
}

//--------------------------------
int resultGetNumber = GetNumber();
//CheckParity();
