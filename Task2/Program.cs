// task 36

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void ReleaseArray(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summa += array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях: {summa}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
ReleaseArray(array);