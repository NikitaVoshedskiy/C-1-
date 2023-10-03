//Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Напишите трехзначное число!!!");
}
else
{
    int f1 = number / 100;
    int f3 = number % 10;
    int f2 = (number - (f1 * 100 + f3))/10;
    System.Console.WriteLine(f2);
}
