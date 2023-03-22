// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
    System.Console.Write("Введите левую границу массива: ");
    int MinValue = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите правую границу массива: ");
    int MaxValue = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < Size; i++)
    {
        arr[i] = new Random().Next(MinValue, MaxValue);
    }
    System.Console.WriteLine($"[{String.Join(", ", arr)}]");
    return arr;
}

int SumElementArray(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int Size = SizeArray();

int[] Array = FillArray(Size);

System.Console.WriteLine($"Сумма элементов массива, стоящих на нечетных индексах, равна: {SumElementArray(Array)}");

