Console.Write("Задайте длину массива: ");
int Massiv = Convert.ToInt32(Console.ReadLine());

int[] CreateMassivRandom(int sizeMassiv, int min, int max)
{
    int[] arr = new int[sizeMassiv];
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }

    return arr;
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

int EvenNumber(int[] arr)
{
    int count = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }

    return count;
}

int[] ListMassiv = CreateMassivRandom(Massiv, 100, 1000);
PrintMassiv(ListMassiv);

int EvenNum = EvenNumber(ListMassiv);
Console.WriteLine($"Колличество четных чисел в массиве: {EvenNum}");
