/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int max = 0;
int i = 0;

Console.WriteLine("Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int [count];

while (i < numbers.Length)
{
    Console.WriteLine("Введите число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

int[] maxNumbers = numbers;



Console.WriteLine("Числом максимума является: " + numbers[i]);