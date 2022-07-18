/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();

Console.WriteLine("Введите пятизначное число, а я проверю, является ли оно палиндромом:");
int num = Convert.ToInt32(Console.ReadLine());

IsItPolindromeFiveDigit(num);

void IsItPolindromeFiveDigit(int number)
{
    int digit5 = number % 10;
    int digit4 = number % 100 / 10;
    int digit2 = number % 10000 / 1000;
    int digit1 = number % 100000 / 10000;

    if (digit5 == digit1 && digit4 == digit2)
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}