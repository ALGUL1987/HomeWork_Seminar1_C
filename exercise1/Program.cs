/*
Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число А: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число B: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue > secondValue)
{
    Console.Write("Числом максимум является: " + firstValue + " Число минимум является: " + secondValue);
}
else
    Console.Write("Числом максимум является: " + secondValue + " Число минимум является: " + firstValue);  