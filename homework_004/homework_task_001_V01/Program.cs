//        Задача:
// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//        Прошрамма :

int GetStep (int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res*=A;
    }
    return res;
}

System.Console.Write("введите число А - ");
int A = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите степен Б - ");
int B = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetStep(A, B));
