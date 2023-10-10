// 33 Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4 массив [6,7,19,345,3] -> no
//3 массив [6,7,19,345,3] -> yes

void rndmas(int[] arr)
{
    Random rnd = new Random();
    for(int i = 0;i<arr.Length;i++)
    {
        arr[i]=rnd.Next(-10,11);
    }
}

   
System.Console.WriteLine("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

rndmas(mas);
System.Console.WriteLine("["+string.Join(", ",mas)+"]");

System.Console.WriteLine(" Введите число которое хотите проверить: ");
int number = Convert.ToInt32(Console.ReadLine());

bool FinD = false;
for(int i=0;i<mas.Length;i++)
    {
        if (mas[i]==number)
        {
            FinD = true;
            break;
        }
        
    }

System.Console.WriteLine(FinD);
