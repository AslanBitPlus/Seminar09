// Задайте значение M и N. Напишите программу, которая
// выведет все натуральные значение в промежутке от M до N.
//
// M = 1; N = 5 => "1, 2, 3, 4, 5"
// M = 4; N = 8 => "4, 5, 6, 7, 7"

void NaturalNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    else Console.Write($"{num1} ");
    
}
// =======================
void NaturalNumbers2(int num1, int num2)
{
    if (num1 < num2)
    {
        NaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num1 > num2)
    {
        NaturalNumbers(num1, num2 + 1);
        Console.Write($"{num2} ");
    }
    else Console.Write($"{num2} ");
    
}


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
// NaturalNumbers(numberM, numberN);

Console.WriteLine();
NaturalNumbers2(numberM, numberN);
