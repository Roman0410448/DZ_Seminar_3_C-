//  Задача 21: Напишите программу, которая принимает на вход координаты двух точек
//   и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) 
// в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
// // Math.Sqrt(25) => 5 (5*5 = 25)
// // Math.Pow(5,2) => 25 
// // a = 1.234
// // Math.Round(a) = 1
// // Math.Round(a, 2) = 1.23
double d = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);

Console.WriteLine(d);
