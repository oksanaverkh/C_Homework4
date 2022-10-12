// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter number A: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number B: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Number A in degree of B = {Degree(a, b)}");

double Degree(double a, double b)
{
    double result = a;
    if (b > 0)
    {
        for (result = a; b > 1; b--)
        {
            result = result * a;
        }
        return result;
    }
    if (b < 0)
    {
        for (result = 1 / a; b < -1; b++)
        {
            result = result / a;
        }
        return result;
    }
    if (b == 0) result = 1;
    return result;
    
    // double result = Math.Pow(a, b);
    // return result;
}


