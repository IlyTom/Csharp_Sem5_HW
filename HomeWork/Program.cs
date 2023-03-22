// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

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


double[] FillArray(int Size)
{
    double[] arr = new double[Size];
    for (int i = 0; i < Size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble()*100,1);
    }
    System.Console.WriteLine($"[{String.Join(" | ", arr)}]");
    return arr;
}

double MinMaxDifference(double[] arr)
{
    double Difference =Math.Round(arr.Max() - arr.Min(),1);
    return Difference;
}


int Size = SizeArray();

double[] Array = FillArray(Size);

System.Console.WriteLine($"Разность между макс.элементом {Array.Max()} и мин.элементом {Array.Min()} равна {MinMaxDifference(Array)}");


