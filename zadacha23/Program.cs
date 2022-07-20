//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int count = 0;
while (count <= N)
{
    int num = array[1] * array[1] * array[1];
    if (num == 0) goto a;
    Console.Write($"{num}, ");
    a:
    count++;
    array[1]++;
}
//Console.WriteLine(count);



