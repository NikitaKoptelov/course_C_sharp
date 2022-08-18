//      Задача :
// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//      Программа :



System.Console.Write("Введите 8 чисел через знак (,) - ");
string nub = Convert.ToString (System.Console.ReadLine());


var nubArray = new List<String> (nub.Split(","));
if (nubArray.Count == 8)
{
    System.Console.Write("Элементы массива - {");
    foreach(string element in nubArray)
    {
        System.Console.Write($" {element} ");
    }
    System.Console.WriteLine("}");
}
else
{
    System.Console.WriteLine("error - введите 8 елементов");
}



