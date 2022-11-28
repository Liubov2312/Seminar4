// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число А - основание степени");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число В - показатель степени");
int Stepen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RaiseNum(Num, Stepen));

int RaiseNum (int Num, int Stepen)
{
    int i = 1;
    int Raise = Num;
    while (i < Stepen)
    {
        Raise *= Num;
        i += 1;
    }
    return Raise;
}
