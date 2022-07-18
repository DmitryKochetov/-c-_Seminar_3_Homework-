/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();

Console.WriteLine("Введите число N, а я выведу таблицу кубов от 1 до N:");
int n = Convert.ToInt32(Console.ReadLine());

TableOfCubes(n);

void TableOfCubes(int number)
{
    int i=1;
    while (i <= number)
    {
        Console.WriteLine($"{i} -> {i*i*i}");
        i++;
    }
}