// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FuncAckerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FuncAckerman(n - 1, 1);
    }
    else return FuncAckerman(n - 1, FuncAckerman(n, m - 1));
    
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int fAckerman = FuncAckerman(numberM, numberN);
Console.WriteLine();
Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM}, {numberN}) = {fAckerman}");
