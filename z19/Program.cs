//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// //решение задачи текстом.
// Console.WriteLine("Введите пятизначное число");
// string number = Console.ReadLine();

// //Сравниваем первое == пятое число и сравниваем второе == четвертое число
// if (number[0] == number[4] && number[1] == number[3])
// {
//     Console.WriteLine($"{number} -> да");
// }
// else
// {
//     Console.WriteLine($"{number} -> нет");
// }


//решение математически.
Console.WriteLine("Введите пятизначное число");
var number = Convert.ToInt32(Console.ReadLine());
var first = number / 10000;
var last = number % 10;
var second = ((number / 1000) % 10 );
var four = ((number % 100) / 10);

if (first == last && second == four)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}

