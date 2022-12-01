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

int[] list = CreateMassivRandom(Massiv, -9, 9);
PrintMassiv(list);

bool FindNumbInMassiv(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]== num) return true;
    }
    return false;
}

Console.Write("Введиде число которое ищем: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданное число присутствует в массиве?");
Console.WriteLine(FindNumbInMassiv(list, number) == true ? "да" : "нет");