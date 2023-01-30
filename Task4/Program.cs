// Статистика
void Array1(int[] array) {
int m;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        m = array[i];
        Console.Write(m + " ");
    }
}
}
void Array2(int[] array) {
int k;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        k = array[i];
        Console.Write(k + " ");
    }
}
}

void Size(int[] array)
{
    int sum1=0, sum2=0;
    foreach (int element in array)
    {
        if (element % 2 != 0)
            sum1 += 1;
        else
        sum2 += 1;
    }
if (sum1 > sum2)
Console.Write("No");
else
Console.Write("Yes");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива от 1 до 100: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 32);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Array1(array);
Console.WriteLine();
Array2(array);
Console.WriteLine();
Size(array);

