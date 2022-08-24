void FillArray(int[] arr, int min, int max)
{

    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] = new Random().Next(min, max + 1);
    }

    return;
}
void PrintArray(int[] arr)
{
    Console.WriteLine("Initial array: '{0}'", string.Join<int>(' ', arr));
    return;
}
void PrintEven(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine("Count of even numbers are: {0}", count);
    return;
}

int[] arr = new int[10];
FillArray(arr, 100, 999);
PrintArray(arr);
PrintEven(arr);