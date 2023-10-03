// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
int digiFirst = number / 100;
//int digiSecond = number / 10;
int digiTherd  = number % 10;
int nov = digiFirst*10 + digiTherd;
System.Console.WriteLine($"{digiFirst} {digiTherd}");
System.Console.WriteLine(nov);