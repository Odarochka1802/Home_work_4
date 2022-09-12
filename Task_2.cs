/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


//Создаем функцию
int getSumNumber(int n)
{

    int counter = Convert.ToString(n).Length;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        result = result + n % 10; //Добавляем последнюю цифру к сумме 
        n = n / 10; //отбрасываем последнюю цифру 
    }
    return result;
}

int sumNumber = getSumNumber(numberN);// присваеваем переменной значение с вызова функци с заданым числом 
Console.WriteLine($"Сумма цифр в числе {numberN}:  {sumNumber}");