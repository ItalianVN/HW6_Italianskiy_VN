/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


void GetPeresechenie(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else
    {
        double X = (b2 - b1) / (k1 - k2);
        double Y = k1 * X + b1;
        Console.WriteLine($"Точка пересечения: ({X}; {Y})");
    }

}

Console.WriteLine("Введите первую постоянную уравнения первой прямой: ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую постоянную уравнения первой прямой: ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую постоянную уравнения второй прямой: ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую постоянную уравнения второй прямой: ");
double k2 = int.Parse(Console.ReadLine());

GetPeresechenie(b1, k1, b2, k2);