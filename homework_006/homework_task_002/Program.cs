//           Задача:
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//                     k1 * x + b1 = k2 * x + b2
//                             b1 = k2 * x + b2 - k1 * x
//                        b1 - b2 = (k2 - k1) * x
//               (b1 - b2) / (k2 - k1) = x
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//         Программа:


Console.Write("введите число k1 - ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите число b1 - ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите число k2 - ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите число b2 - ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата точки пересечения - ");
Console.WriteLine($"({GetXNub(k1, b1)}; {GetYNub(k2, b2)})");



double GetXNub (double k1, double b1)
{
    double x = (b1 - b2) / (k2 - k1);
    return x;
}

double GetYNub (double k2, double b2)
{
    double y = k2 * GetXNub(k1, b1) + b2;
    return y;
}


