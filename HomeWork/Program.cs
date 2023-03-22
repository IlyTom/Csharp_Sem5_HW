// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int SizeArray()
{
    System.Console.Write("Введите размерность массива: ");
    int size = int.Parse(Console.ReadLine()!);
    while (true)
        if (size > 0) return size;
        else
        {
            System.Console.WriteLine("Введено неверное число, повторите ввод.");
            size = int.Parse(Console.ReadLine()!);
        }
}


int[] FillArray(int Size)
{
    int[] arr = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    System.Console.WriteLine($"[{String.Join(", ", arr)}]");
    return arr;
}

int CheckElementArray(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}

int Size = SizeArray();

int[] Array = FillArray(Size);

System.Console.WriteLine($"В массиве находится {CheckElementArray(Array)} четных чисел");

