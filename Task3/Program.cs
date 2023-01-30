// task 38

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Console.Write("Введите элементы массива: ");
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= max)
    {
        max = array[i];
    }
    if (array[i] <= min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
double result = Math.Round((max -min),2);
Console.WriteLine($"Разница: {result}");