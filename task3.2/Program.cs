﻿//Напишите программу, которая по
//заданному номеру четверти, показывает
//диапазон возможных координат точек в этой
//четверти (x и y).


void NUMchet (int num)
{
    
   if (num == 1)
     {
     System.Console.WriteLine("X>0 Y>0");
     }
 else if (num == 2)
        {     
         System.Console.WriteLine("X<0 Y>0");
       }
   else if ( num == 3)
    {
       System.Console.WriteLine("X<0 Y<0 ");
     }
   else if (num == 4)
     {
     System.Console.WriteLine("X>0 Y<0");
     }
     else
     {
        System.Console.WriteLine("Такой четверти нет");
     }
}

Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

NUMchet (num);