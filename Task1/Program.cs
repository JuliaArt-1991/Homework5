// task 34

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void ReleaseArray(int[] array)
{
    int summachetnye = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
            summachetnye += 1;
    }
    Console.WriteLine($"Количество четных чисел равно: {summachetnye}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
