void fillArray(int[] array)
{
    int Length = array.Length;
    for(int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(-15, 15);
    }
}

Console.Write("Insert the Length of an array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
fillArray(array);
Console.Write($"[{String.Join(", ", array)}]");