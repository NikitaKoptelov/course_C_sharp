//      Задача :
// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//      Программа :


string GetNubArray (string nub, int index)
{
    var NubArray = new List<String> (nub.Split(","));
    return NubArray[index];
}

string GetElementMass (string nub)
{
    int j = 0;
    string ElementsMass = string.Empty;
    
    while (j < 8)
    {
        ElementsMass += GetNubArray(nub, j);
        ElementsMass += "  ";
        j++;
    }
    return ElementsMass;
}

System.Console.Write("Введите 8 элементов через знак (,) - ");
string nub = Convert.ToString(System.Console.ReadLine());
System.Console.WriteLine(GetElementMass(nub));

