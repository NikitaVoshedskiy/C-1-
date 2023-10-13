// 45 напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 

void FullRage (int[] args)
{
    Random rnd = new Random();
    for (int i = 0; i < args.Length; i++)
    {
       args[i]= rnd.Next(0,10);
    }
}

int[] CopyArr(int [] arr)
{
    int[] arr2 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i]=arr[i];
    }
    return arr2;
}

System.Console.WriteLine("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

FullRage(mas);
System.Console.WriteLine("["+string.Join(", ",mas)+"]");

int[] mis = CopyArr(mas);
System.Console.WriteLine("["+string.Join(", ",mis)+"]");