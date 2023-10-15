void fillArray(int[] array)
{
    int Length = array.Length;
    for(int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(-15, 15);
    }
}

void SumArray(int[] array)
{
    int sum_p = 0, sum_n = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] < 0)
             sum_n += array[i];
        else
             sum_p += array[i];
    Console.WriteLine($"Sum of positive numbers: {sum_p}; sum of negative numbers: {sum_n}.");
}

Console.Write("Insert the Length of an array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
fillArray(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
SumArray(array);