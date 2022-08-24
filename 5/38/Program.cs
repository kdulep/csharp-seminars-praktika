void FillArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] = Math.Round(new Random().NextDouble(),2);
    }

    return;
}
void PrintArray(double[] arr)
{
    Console.WriteLine("Initial array: '{0}'", string.Join<double>(' ', arr));
    return;
}
void PrintMinMaxDiff(double[] arr)
{
    double min = arr[0], max = arr[0];
    foreach (var item in arr.Select((value, i) => new { i, value }))
    {
        var value = item.value;
        var index = item.i;
        if (value < min) { min = value; }
        if (value > max) { max = value; }
    }
    Console.WriteLine("Diffrence max-min {0:F2}", max-min);
    return;
}

double[] arr = new double[5];FillArray(arr);
//double[] arr={ 3,7,22,2,78 };
PrintArray(arr);
PrintMinMaxDiff(arr);