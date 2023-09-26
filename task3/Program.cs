// Написали программу, оторая при вводе числа выдает день недели

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <1 || number > 7) // || - или , && - и
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
if (number == 1)
{
    Console.WriteLine("Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Понедельник");
}
if (number == 3)
{
    Console.WriteLine("Понедельник");
}
if (number == 4)
{
    Console.WriteLine("Понеельник");
}
if (number == 5)
{
    Console.WriteLine("Понедельник");
}
if (number == 6)
{
    Console.WriteLine("Понедльник");
}
if (number == 7)
{
    Console.WriteLine("Понедельк");
}
}

// Вариант 2
/*
switch (nomer)
{
case 1:
{
Console.WriteLine("понедельник");
break;
}
case 2:
{
Console.WriteLine("вторник");
break;
}
case 3:
{
Console.WriteLine("среда");
break;
}
case 4:
{
Console.WriteLine("четверг");
break;
}
case 5:
{
Console.WriteLine("пятница");
break;
}
case 6:
{
Console.WriteLine("суббота");
break;
}
case 7:
{
Console.WriteLine("воскресенье");
break;
}
default:
{
Console.WriteLine("нет такого дня недели");
break;
}
}
*/
