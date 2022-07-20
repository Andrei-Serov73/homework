//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты числа A: ");
Console.Write("x =");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y =");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("z =");
int z = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты числа B: ");
Console.Write("x1 =");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 =");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 =");
int z1 = Convert.ToInt32(Console.ReadLine());

double num = (x1-x)^2+(y1-y)^2+(z1-z)^2;
//double num = Math.Sqrt((x1-x)^2+(y1-y)^2+(z1-z)^2);
Console.WriteLine($"A ({x},{y},{z}); B ({x1},{y1},{z1}) -> {num};");
