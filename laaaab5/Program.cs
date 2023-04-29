double[] array = new double[100];
rand();
double average = arr(array);
Console.WriteLine($"Среднее арифметическое: {average}");
double geometricMean = geom(array);
Console.WriteLine($"Среднее геометрическое: {geometricMean}");
double squareMean = qad(array);
Console.WriteLine($"Среднее квадратичное: {squareMean}");
void rand()
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 100;
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F2} ");
        if ((i + 1) % 10 == 0)
        {
            Console.WriteLine();
        }
    }
}
double arr(double[] array)
{
    double sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum / array.Length;
}
double geom(double[] array)
{
    double product = 1;

    for (int i = 0; i < array.Length; i++)
    {
        product *= array[i];
    }

    return Math.Pow(product, 1.0 / array.Length);
}
double qad(double[] array)
{
    double sumOfSquares = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sumOfSquares += Math.Pow(array[i], 2);
    }

    return Math.Sqrt(sumOfSquares / array.Length);
}


