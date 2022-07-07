/*  Задайте массив из 12 элементов, заполненный случайными 
числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
   Задача 1. Напишите программу замена элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.
   Задача 2. Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
   Задача 3. Задайте массив из 20 случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [10,99].
*/
/*

Console.WriteLine("Введите размер массива");
int size =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max =Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {   
                array[i] = new Random().Next(min, max+1);
            }
        return array;
    }

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int sumaMax(int[] array)
{
    int sumMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)  sumMax = sumMax + array[i];
    }
    return sumMax;
}

int sumaMin(int[] array)
{
    int sumMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)  sumMin = sumMin + array[i];
    }
    return sumMin;
}


int[] MyArray = RandomArray(size, min, max);
ShowArray(MyArray);
Console.WriteLine("Кол-во + элем масиива = " + sumaMax(MyArray));
Console.WriteLine("Кол-во - элем масиива = " + sumaMin(MyArray));
*/


/*
Console.WriteLine("Введите размер массива");
int size =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max =Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {   
                array[i] = new Random().Next(min, max+1);
            }
        return array;
    }

void ShowArray(int[] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MyArray = RandomArray(size, min, max);
ShowArray(MyArray);

void Zamena(int[] array)
{
    Console.WriteLine("Новый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array [i] * -1;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Zamena(MyArray);
*/

/*
Console.WriteLine("Введите размер массива");
int size =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max =Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {   
                array[i] = new Random().Next(min, max+1);
            }
        return array;
    }

void ShowArray(int[] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MyArray = RandomArray(size, min, max);
ShowArray(MyArray);

void Proverka(int[] array, int chislo)
{
    int y = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]==chislo) Console.WriteLine("Такое же число на индексе " + i);     
        else y = y + 1;
    }
    if (y==array.Length) Console.WriteLine("Нет такого числа");
}
Console.WriteLine("Введите число для проверки");
int chislo =Convert.ToInt32(Console.ReadLine());
Proverka(MyArray, chislo);
*/

/*
Console.WriteLine("Введите размер массива");
int size =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max =Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {   
                array[i] = new Random().Next(min, max+1);
            }
        return array;
    }

void ShowArray(int[] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MyArray = RandomArray(size, min, max);
ShowArray(MyArray);

int KolvoelOtrez(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>=10 && array[i]<=99) sum=sum+1;
    }
    return sum;
}

Console.WriteLine("Кол-во элем. в диапазоне от 10 до 99 равно " + KolvoelOtrez(MyArray));
*/

