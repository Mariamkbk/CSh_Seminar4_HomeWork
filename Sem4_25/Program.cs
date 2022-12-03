// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Нельзя через Math.Pow.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exponent(double A, double B)
{
    double mult = 1;
    for (int i = 1; B > 0 && i <= B; i++) mult *= A;
    return mult;
}

try
{
    Console.WriteLine("Введите число А");
    double A = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число B");
    double B = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{A} в степени {B} равно {Exponent(A, B)}");
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
