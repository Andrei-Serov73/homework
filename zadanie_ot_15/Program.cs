//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//строки и массивы использовать нельзя

//Console.Write("Введите пятизначное число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//void palindrom (string num)
//{
  //if (num[0] == num[4] || num[1] == num[3])
  //{
  //Console.WriteLine($"Ваше число: {num} - палиндром.");
  //}
  //else{
    //Console.WriteLine($"Ваше число: {num} - не палиндром.");
  //}
//}
//if (num.Length == 5){
  //palindrom(num);
//}
//else{
    //Console.WriteLine("Введите правильное число.");
//}

// первое решение через строку


Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
void palindrom (int num){
int a = num / 10000;                          
int b = num / 1000 - a * 10;                  
int c = num / 100 - a * 100 - b * 10;         
int d = num / 10 - a * 1000 - b * 100 - c *10;  
int e = num / 1 - a * 10000 - b * 1000 - c *100 - d * 10;
if(a == e && b == d){
  Console.WriteLine($"Ваше число: {num} - палиндром.");
}
else{
Console.WriteLine($"Ваше число: {num} - не палиндром.");
}
}
string str = Convert.ToString(num);
if (str.Length == 5){
  palindrom(num);
}
else{
    Console.WriteLine("Введите правильное число (положительное пятизначное!).");
}
// строку использовал для проверки числа - по-другому не додумался.
