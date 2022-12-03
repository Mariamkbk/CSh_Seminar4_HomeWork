// Напишите программу, которая принимает на вход целое или дробное 
// число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

Console.WriteLine("Введите целое или дробное число");
double num = Convert.ToDouble(Console.ReadLine());
int count = 0;
while(num != Math.Round(num)) num=num*10;
while (num > 0) 
{
    num=Math.Round(num/10);
    count++;
}
Console.WriteLine($"В заданном числе {count} цифр");