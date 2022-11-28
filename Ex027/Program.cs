// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(Num));

int SumNum(int Num)
{
    int Sum = 0;
    int i = 0;
    while (Num > 0)
    {
        i = Num % 10;
        Sum += i;
        Num /= 10;
    }  
    return Sum;  
}