Console.Write("Задайте длину массива: ");
int Massiv = Convert.ToInt32(Console.ReadLine());

double[] CreateMassivRandom(int sizeMassiv)
{
    double[] arr = new double[sizeMassiv];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }

    return arr;
}

void PrintMassiv(double[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.WriteLine("]");
}

void MaxMinNumber(double[] arr)
{
    double min = arr[0]; // так-же можно использовать min = ToInt32.MaxValue
    double max = arr[0]; // так-же можно использовать max = ToInt32.MinValue

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }

    Console.WriteLine($"Максимальное значение -> {max}");
    Console.WriteLine($"Минимальное значение -> {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значениями -> {max - min}");
}

double[] ListMassiv = CreateMassivRandom(Massiv);
PrintMassiv(ListMassiv);
MaxMinNumber(ListMassiv);