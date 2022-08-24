void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] = new Random().Next(-10, 11);
    }

    return;
}
void PrintArray(int[] arr)
{
    Console.WriteLine("Initial array: '{0}'", string.Join<int>(' ', arr));
    return;
}
void PrintEvenPosSum(int[] arr)
{
    int sum = 0;
    foreach (var item in arr.Select((value, i) => new { i, value }))
    {
        var value = item.value;
        var index = item.i;
        if (index % 2 != 0) { sum += value; }
    }
    Console.WriteLine("Sum of non even index are: {0}", sum);
    return;
}

int[] arr = new int[5];
FillArray(arr);
//int[] arr={3,7,23,12};
PrintArray(arr);
PrintEvenPosSum(arr);