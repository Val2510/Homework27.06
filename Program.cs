//Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99,999);
}
string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int EvenNumbers(int[] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count = count + 1;
}
return count;
}

int size = InputNum("Введите размер массива: ");

int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);

int even = EvenNumbers(myArray);
Console.WriteLine(even);
*/


//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму 
//элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1);

}
string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int SumOdd(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ = summ + array[i];
        }
    }
    return summ;
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
Console.WriteLine(txt);

int sumNumbers = SumOdd(myArray);
Console.WriteLine(sumNumbers);
*/


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArray()
{
    return new double[10];
}

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.NextDouble(), 2);

}
string PrintArray(double[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

double Diff(double[] array)
{
    int imin = 0;
    int imax = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[imax])
            imax = i;
        if (array[i] < array[imin])
            imin = i;

    }
    return array[imax] - array[imin];
}

double[] myArray = CreateArray();
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);

double difference = Diff(myArray);
Console.WriteLine(difference);