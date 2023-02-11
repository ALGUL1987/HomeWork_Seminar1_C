/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[count];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Введите число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int max = 0;

for (int i = 0; i < numbers.Length; i++)

{
    if (numbers[i] > max)
    {
    max = numbers[i];
    }
}
Console.WriteLine("Числом максимум является: " + max);