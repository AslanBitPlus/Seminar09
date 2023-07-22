// Напишите программу, которая будет принимать на вход число и
// и возвращать сумму его цифр.

// ==========================
int SumDigits(int num)
{
    if (num < 10) return num;
    else return num % 10 + SumDigits(num / 10);   
}

// ==========================
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDig = SumDigits(number);
Console.WriteLine();
Console.Write($"Сумма цифр числа {number} равна {sumDig}");
