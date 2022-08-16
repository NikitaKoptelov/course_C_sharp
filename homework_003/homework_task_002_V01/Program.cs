//         Задача :
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//         Программа:



double GetCoords (string coords, int index)
{
    string[] array = new string[3];
    array = coords.Split(",");      

    return Convert.ToDouble(array[index]);
}


System.Console.Write("Введите 3х мерные координаты точки А через (,) - ");
string coordsA = Convert.ToString (System.Console.ReadLine());

System.Console.Write("Введите 3х мерные координаты точки Б через (,) - ");
string coordsB = Convert.ToString (System.Console.ReadLine());

System.Console.Write("Длинна отрезка АБ - ");
System.Console.WriteLine(GetLenghAB());


double GetLenghAB ()
{
    double lengAB = Math.Sqrt(Math.Pow((GetCoords(coordsB, 0) - (GetCoords(coordsA, 0))), 2) + Math.Pow((GetCoords(coordsB, 1) - (GetCoords(coordsA, 1))), 2) + Math.Pow((GetCoords(coordsB, 2) - GetCoords(coordsA, 2)), 2));
    return lengAB;    
}




