// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √((xb - xa)2 + (yb - ya)2 + (zb - za)2)

Console.WriteLine("Введите координату точки A по x: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по x: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по y: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по z: ");
int zb = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));

Console.WriteLine($"{res:f2}");

