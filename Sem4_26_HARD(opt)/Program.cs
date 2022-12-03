// Напишите программу, которая принимает на вход целое или дробное
// число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

decimal NumCount(decimal num)
{
int count = 0;
if (num < 0) num = -num;
if (num==0) count = 1;
while (Math.Floor(num) == 0 && num!=0)
{
    num *= 10;
    count++;
}
while (num != Math.Floor(num)) num *= 10;
while (num > 0)
{
    num = Math.Floor(num / 10);
    count++;
}
return count;
}
try
{
Console.WriteLine("Введите целое или дробное число");
decimal num = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Количество цифр числе {num} равно {NumCount(num)}");
}
catch
{
    Console.WriteLine("Введены некорректные данные");
}