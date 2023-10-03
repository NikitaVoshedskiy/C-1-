//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

System.Console.WriteLine("Введите число дня недели:");
int number = Convert.ToInt32(Console.ReadLine());
int day = 0;

if (number < 1 || number >7)
{
     System.Console.WriteLine("Введите верное число");
}
else
{
if (number == 1)
{
    Console.WriteLine("Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Вторник");
}
if (number == 3)
{
    Console.WriteLine("среда");
}
if (number == 4)
{
    Console.WriteLine("четверг");
}
if (number == 5)
{
    Console.WriteLine("пятница");
}
if (number == 6)
{
    day = 6;
    Console.WriteLine("суббота");
}
if (number == 7)
{
    day = 7;
    Console.WriteLine("воскресенье");
}
}

if (day == 6 || day == 7)
{
    System.Console.WriteLine("Сегодня выходной");
}
else
{
    System.Console.WriteLine("Сегодня не выходной, иди работать!");
}
