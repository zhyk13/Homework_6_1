// Программа создает кпию заданного массиа.

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,10);
    }
    return arr;
}

int GetNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CopyArray(int[] soursearr)
{
    int[] newarray = new int[soursearr.Length];
    for (int i = 0; i < soursearr.Length; i++)
    {
        newarray[i] = soursearr[i];
    }
    return newarray;
}

int[] array = new int[GetNumber("Введите кол-во элементов массива: ")];
array = FillArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
int[] arraycopy = new int[array.Length];
arraycopy = CopyArray(array);
Console.WriteLine($"[{string.Join(", ", arraycopy)}]");



Console.WriteLine("Hello, World!");
