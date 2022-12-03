// Напишите программу, которая задаёт массив из
// 8 элементов с клавиатуры и выводит массив на экран.
//либо цикл for либо split.
void FillArray(double[] SomeArray)
{
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите {i + 1} число массива");
        SomeArray[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void PrintArray(double[] RandomArray)
{
    for (int i = 0; i < 8; i++) Console.Write($"{RandomArray[i]} ");
}
try
{
    double[] array = new double[8];
    FillArray(array);
    PrintArray(array);
}
catch 
{
    Console.WriteLine($"Введены некорректные данные");
}
