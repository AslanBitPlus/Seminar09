// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        return num1 + SumNaturalNumbers(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        return num1 + SumNaturalNumbers(num1 - 1, num2);
    }
    else return num1;
    
}

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNaturalNumbers(numberM, numberN);
Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} = {sumNumbers}");
