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

int GetSumNeg(int[] arr)
{
    int sumNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNeg += arr[i];
    }
    
    return sumNeg;
}

int GetSumPos(int[] arr)
{
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos += arr[i];
    }
    
    return sumPos;
}

int[] list = CreateMassivRandom(12, -9, 9);
PrintMassiv(list);

int sumNegetiv = GetSumNeg(list);
Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegetiv}");
int sumPossitive = GetSumPos(list);
Console.WriteLine($"Сумма положительных элементов массива: {sumPossitive}");