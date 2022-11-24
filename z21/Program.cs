//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
////AB = √(x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2
//Pow(double a, double b): возвращает число a, возведенное в степень b
//Sqrt(double value): возвращает квадратный корень числа value

int x1,y1,z1;
int x2,y2,z2;
Console.WriteLine("Введите x1");
x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1");
y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2");
x2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2");
y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
z2=Convert.ToInt32(Console.ReadLine());
double ab = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) ->");
Console.WriteLine("{0: 0.00}", ab);