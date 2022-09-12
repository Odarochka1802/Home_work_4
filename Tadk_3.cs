/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


int[] getArray()
{
    int[] array = new int[8]; // задаем массив из 8 элементов type int
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите символ под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// Метод вывода массива на экран через for

void PrintArrayToConsole(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
int[] array = getArray();
PrintArrayToConsole(array);

/*Второй способ вывести массив
Console.WriteLine("[{0}]", string.Join(", ", array));
*/