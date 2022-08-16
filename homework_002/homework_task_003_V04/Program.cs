//         Задача:
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
//              Программм:

// множество             {     0,      1,     2,     3,     4,    5,    6,    7}
string[] NumbWeekArray = {"error", "нет", "нет", "нет", "нет", "нет", "да", "да"};

string GetWeeks (int numb)
{
    return NumbWeekArray[numb];
}

System.Console.Write("Введите номер дня недели - ");
string numbs = Convert.ToString(System.Console.ReadLine());

int numbValue;
int.TryParse(string.Join("", numbs.Where(c => char.IsDigit(c))), out numbValue);

System.Console.WriteLine($"Введенное число - {numbValue}");

if(6 <= numbValue && numbValue <= 7)
{
    System.Console.WriteLine(GetWeeks(numbValue));
}
else if (1 <= numbValue && numbValue <= 5)
{
    System.Console.WriteLine(GetWeeks(numbValue));
}
else
{
    System.Console.WriteLine(GetWeeks(0));
}

