/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координату X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

GiveMeDistance3D(x1, y1, z1, x2, y2, z2);

void GiveMeDistance3D(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(xc2 - xc1, 2) + Math.Pow(yc2 - yc1, 2) + Math.Pow(zc2 - zc1, 2)), 2, MidpointRounding.ToZero);
    Console.WriteLine($"A ({xc1},{yc1},{zc1}); B ({xc2},{yc2},{zc2}), -> {distance}");
}