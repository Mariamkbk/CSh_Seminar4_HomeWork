// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке..
// Далее надо посчитать количество нулей и единиц,
// если единиц больше чем нулей то вывести
// TRUE на экран, иначе вывести False.

void FillArray(int[] SomeArray)
{
    for (int i = 0; i < 8; i++)
    {
        SomeArray[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] RandomArray)
{
    for (int i = 0; i < 8; i++)
        Console.Write($"{RandomArray[i]} ");
}
string NullOneCount(int[] AnothArray)
{
    string res = String.Empty;
    int CountOne = 0;
    int CountNull = 0;
    for (int i = 0; i < 8; i++)
    {
        while (AnothArray[i] == 1) CountOne++;
    }
    for (int i = 0; i < 8; i++)
    {
        while (AnothArray[i] == 0) CountNull++;
    }
    if (CountOne > CountNull) res = res + "true";
    else if (CountOne < CountNull) res = res + "false";
    else res = res + "Equal";
    return res;
}
try
{
    int[] array = new int[8];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine(NullOneCount(array));
}
catch
{
    Console.WriteLine($"Введены некорректные данные");
}
