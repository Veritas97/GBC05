Console.Write("Задайте длину массива: ");
int Massiv = Convert.ToInt32(Console.ReadLine());

int[] CreateMassivRandom(int sizeMassiv, int min, int max)
{
    int[] Massiv = new int[sizeMassiv];
    Random random = new Random();

    for (int i = 0; i < Massiv.Length; i++)
    {
        Massiv[i] = random.Next(min, max + 1);
    }

    return Massiv;
}

void PrintMassiv(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.WriteLine("]");
}

int FindElements(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100) count ++;
    }
    return count;
}

int[] list = CreateMassivRandom(Massiv, 0, 1000);
PrintMassiv(list);
int FindCount = FindElements(list);
if (FindCount > 0) Console.WriteLine($"Колличество двухзначных элементом = {FindCount}");
else Console.WriteLine("В данном массиве нет двухзначных элементом");