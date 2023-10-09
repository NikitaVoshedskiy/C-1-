//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Steps (int numA, int numB)
{
     
    int step = 1;
    for (int i = 0; i < numB; i++)
    {
    step = step * numA;
    }
    return step;
}

bool Expo (int numB)
{
    if (numB<0)
    {
     
       System.Console.WriteLine("Число В не может быть отрицательным");
       return false;
    }
    return true;
}

System.Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());

if (Expo(B))
{
    System.Console.WriteLine($"{A}+{B}+{Steps(A,B)}");
}

