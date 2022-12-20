// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void PrintNumbers(int M, int N)
{
    if (M >= N + 1) return;
    if (M % 2 == 0) System.Console.Write($"{M}, ");
    PrintNumbers(M + 1, N);
}

int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("Задайте значения M и N");
PrintNumbers(Prompt("Введите M: "), Prompt("Введите N: "));