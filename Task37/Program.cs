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

int[] NewList(int[] arr)
{
    int ListSize = arr.Length / 2;
    if (arr.Length % 2 == 1) ListSize += 1;
    int[] newList = new int[ListSize];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newList[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newList[ListSize - 1 ] = arr[arr.Length / 2];
    return newList;
}

int[] list = CreateMassivRandom(Massiv, 1, 10);
PrintMassiv(list);
int[] ListNew = NewList(list);
PrintMassiv(ListNew);