// void fillArray(int[] array)  // заполняем массив возврат не нужен!!!
// {
//     int Length = array.Length;
//     for(int i = 0; i < Length; i++)
//     {
//         array[i] = new Random().Next(-15, 15);
//     }
// }

// void SumArray(int[] array)
// {
//     int sum_p = 0, sum_n = 0;
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] < 0)
//              sum_n += array[i];
//         else
//              sum_p += array[i];
//     Console.WriteLine($"Sum of positive numbers: {sum_p} \n sum of negative numbers: {sum_n}.");
// }

// Console.Write("Insert the Length of an array: ");
// int n = Convert.ToInt32(Console.ReadLine());      // the number of elements in an array
// int[] array = new int[n];                  // create array with the inserted number of elemnts
// fillArray(array);                         // call for thefunction, fill i the array
// Console.WriteLine($"[{String.Join(", ", array)}]");   // make from array to string
// SumArray(array);                //  call for the sum function 
//..........................................................................................................


// make them change their +/-
// void fillArray(int[] array) 
// {
//     int Length = array.Length;
//     for(int i = 0; i < Length; i++)
//     {
//         array[i] = new Random().Next(-15, 15);
//     }
// }

// void Change(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//        array[i] *= (-1);
//     Console.WriteLine($"[{String.Join(", ", array)}]"); 
// }

// Console.Write("Insert the Length of an array: ");
// int n = Convert.ToInt32(Console.ReadLine());   
// int[] array = new int[n];                  
// fillArray(array);                         
// Console.WriteLine($"[{String.Join(", ", array)}]");   
// Change(array);                
//......................................................................

// find a certain number

// void fillArray(int[] array) 
// {
//     int Length = array.Length;
//     for(int i = 0; i < Length; i++)
//     {
//         array[i] = new Random().Next(-15, 15);
//     }
// }

// string Find(int[] array, int f)
// {
//     for (int i = 0; i < array.Length; i++)
//     {   
//         if(array[i] == f)
//             return "yes";
//     }
//         return "no";
    
// }

// Console.Write("Insert the Length of an array: ");
// int n = Convert.ToInt32(Console.ReadLine());   
// int[] array = new int[n];                  
// fillArray(array);                         
// Console.WriteLine($"[{String.Join(", ", array)}]");  
// Console.Write("Insert the number you want to find: ");
// int x = Convert.ToInt32(Console.ReadLine());   
// Console.WriteLine(Find(array, x));              
//.........................................................................................

void fillArray(int[] array) 
{
    int Length = array.Length;
    for(int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(0, 150);
    }
}

int EmNumbers(int[] array)
{
    int x = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i] >= 10 && array[i] <= 99)
        x += 1;
    }
        return x;
    
}

Console.Write("Insert the Length of an array: ");
int n = Convert.ToInt32(Console.ReadLine());   
int[] array = new int[n];                  
fillArray(array);                         
Console.WriteLine($"[{String.Join(", ", array)}]");  
Console.Write($"There are {EmNumbers(array)} numbers between 10 and 99");
