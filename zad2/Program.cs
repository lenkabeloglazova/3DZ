// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите х для точки 1: ");
Console.WriteLine("Введите y для точки 1: ");
Console.WriteLine("Введите z для точки 1: ");
Console.WriteLine("Введите х для точки 2: ");
Console.WriteLine("Введите y для точки 2: ");
Console.WriteLine("Введите z для точки 2: ");

double x1 = Convert.ToInt64(Console.ReadLine());
double  y1 =Convert.ToInt64(Console.ReadLine ());
double  z1 =Convert.ToInt64(Console.ReadLine ());
 double x2 = Convert.ToInt64(Console.ReadLine());
double  y2 = Convert.ToInt64(Console.ReadLine());
double z2 = Convert.ToInt64(Console.ReadLine());

double  A = x2 - x1;
double  B = y2 - y1;
double  C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Ответ = " + length);
