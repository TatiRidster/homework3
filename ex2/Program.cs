// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
double Get3DLine(int X1,int Y1,int Z1,int X2,int Y2,int Z2)
{
     double Result = (X1-X2)*(X1-X2) + (Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2);
     Result = Math.Sqrt(Result);
    return Result;
}

Console.WriteLine("Введите координаты X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
double length = Get3DLine(X1,Y1,Z1,X2,Y2,Z2);
Console.WriteLine($"Расстояние равно: {length}");
