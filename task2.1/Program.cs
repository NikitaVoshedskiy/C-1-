// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
//показывает наибольшую цифру числа.

int number = new Random().Next(10, 100); // [10; 100) == [10; 99]
Console.WriteLine($"Случайное число: {number}");
int digitFirst = number / 10;
int digitSecond = number % 10;

if (digitFirst > digitSecond)
{
Console.WriteLine(digitFirst);
}
else if (digitFirst < digitSecond)
{
Console.WriteLine(digitSecond);
}
else
{
Console.WriteLine("Цифры равны");
}