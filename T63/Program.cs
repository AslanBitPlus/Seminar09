// Задайте значение N. Напишите программу, которая
// выдает все натуральные значение от 1 до N.
//
// N = 5 => "1, 2, 3, 4, 5"
// N = 6 => "1, 2, 3, 4, 5, 6"

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

NaturalNumbers(number);
