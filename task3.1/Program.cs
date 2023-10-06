//Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
//номер четверти плоскости, в которой находится эта
//точка.

void DetectedQ (int x, int Y)
{
   if (x > 0 && y > 0)
     {
     System.Console.WriteLine("Первая четверть");
     }
 else if (x<0 && y > 0)
        {     
         System.Console.WriteLine("Вторая четверть");
       }
   else if ( x< 0 && y< 0)
    {
       System.Console.WriteLine("третья четверть ");
     }
   else  
     {
     System.Console.WriteLine("четвертая четверть ");
     }
}

Console.Write("Введите координаты X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());

DetectedQ (x,y);
