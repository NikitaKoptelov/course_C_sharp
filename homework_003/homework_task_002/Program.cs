//         Задача :
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//         Программа:


double xA = 3, yA = 6, zA = 8,
    xB = 2, yB = 1, zB = -7;
double lengAB;

lengAB = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));

System.Console.WriteLine(lengAB);


