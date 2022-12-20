// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
int SummNumbers(int M, int N)
{
    if (M == N) return N;
    return M + SummNumbers(M + 1, N);
}

int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("Задайте значения M и N");
System.Console.WriteLine(SummNumbers(Prompt("Введите M: "), Prompt("Введите N: ")));