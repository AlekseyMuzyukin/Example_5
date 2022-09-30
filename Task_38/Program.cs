Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
double[] Array1 = new double[a];

InputArray(Array1);
PrintArray(Array1);
DifferenceMaxMin(Array1);


void InputArray(double[] array, int minsize = 0, int maxsize = 100)
{
    Random rnd = new Random();
    for (int i = 0; i <= array.Length - 1; i++)
        array[i] = Math.Round(rnd.NextDouble() * (maxsize - minsize) + minsize, 1);
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

void DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($" Разница между максимальным и минимальным элементом массива {Math.Round(max - min, 1)}");

}