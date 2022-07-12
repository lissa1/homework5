//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
int[] numbers = new int[12];
int count = 0;
FillArray(numbers);
PrintArray(numbers);
FindPositiveNum(numbers);

void FindPositiveNum(int[] array)
{
    for (int i = 0; i <= numbers.Length; i++)
    {
        if (i % 2 == 0) count++;
    }
    Console.WriteLine($"число положительных чисел равно {count}");
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
