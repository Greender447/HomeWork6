// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int SizeArray (string size)
{
    Console.WriteLine(size);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = SizeArray ($"Введите {i + 1}-й элемент");
    }
    return array;
}


void PrintArray(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        Console.WriteLine(array[i]);
    }
}

int PositivNumbers(int[] array)
{
    int number = 0;
    for(int i = 0;i < array.Length;i++)
    {
        if(array[i] > 0)
        {
            number++;
        }
    }return number;
}

int lenght = SizeArray("Введите количество элементов массива : ");//Пользователь задал длину массива
int[] array; // Создали массив
array = EnterArray(lenght); // Пользователь вводит элементы массива
PrintArray(array); // Вывод массива в консоль
Console.WriteLine(); // переход на следующую строку 
Console.WriteLine($"Число положительных чисел = {PositivNumbers(array)}"); // выводит количество положительных чисел
