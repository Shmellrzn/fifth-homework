/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*
Console.Write("Введите А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int a = num1;
{ 
    for(int i = 1; i < num2; i++)
    
    {
       a = a * num1;
    }
    
}
Console.WriteLine($"Степень числа {num1} в {num2} является {a}");
*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*
int SumofDigits(int num)
{
    int sum = 0;
    for(int i = 1; i > 0; i++)
    {
        int des = num % 10;
        num = num / 10;
        sum += des;
        
    }
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumofDigits(num);

Console.WriteLine($"Сумма цифр в числе {num} равняется {result}");
*/



/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int []CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
     {
        Console.WriteLine($"Массив, состоящий из 8-ми элементов: [{array[i]}]");
     }
}

Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(8, min, max);
ShowArray(myArray);