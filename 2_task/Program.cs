// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
int[] numbers = new int[12];
int sum = 0;
FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 1)
    {
        sum += numbers[i];
    }
}
Console.WriteLine($"сумма чисел равна {sum}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
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
