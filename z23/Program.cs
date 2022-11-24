//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
var num = Convert.ToInt32(Console.ReadLine());
var start_text = "";
for (int i = 1; i <= num; i++)
{
    //Для вставки одной строки в другую применяется функция Insert:
    start_text = start_text.Insert(start_text.Length, Convert.ToString(Math.Pow(i, 3)) + ", ");
}
Console.WriteLine(start_text);