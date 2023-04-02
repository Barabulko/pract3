// See https://aka.ms/new-console-template for more information
Console.WriteLine("task21");

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

void getVectorLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dX = x2-x1;
    double dY = y2-y1;
    double dZ = z2-z1;
    double result = Math.Sqrt(dX*dX+dY*dY+dZ*dZ);
    Console.WriteLine($"{result:f3}");
}

Console.Write("please enter x1 ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("please enter y1 ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("please enter z1 ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("please enter x2 ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("please enter y2 ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("please enter z2 ");
int z2 = int.Parse(Console.ReadLine());
getVectorLength(x1, y1, z1, x2, y2, z2);