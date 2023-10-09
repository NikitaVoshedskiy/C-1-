// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 ->3
//78 -> 2
// 89126 ->5

int Colvochisel(int num)
{
    int result = 0;
    if(num == 0) 
    {
        return result+1;
    }
    else
    {
        while (num>=1)
        {
             num = num / 10;
             result++;
        }
        return result;
    }
    
}

System.Console.WriteLine("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = Colvochisel(N);
System.Console.WriteLine(result);

//Второй вариант решенеия

//System.Console.WriteLine("Введите число: ");
//int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//string num = Convert.ToString(N); - 123 == "123"
//System.Console.WriteLine(num.Length); - ширину строки считает
