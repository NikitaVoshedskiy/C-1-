// 35 задайте одномерный массив из n случайных чисел. 
//Найдите количетство элементов массива, значения которых лежат в отрезке [10,99]
//[5,18,123,6,2]->1
//[1,2,3,6,2] -> 0

void MAS (int[] arr)
{
    Random rnd = new Random();
    for(int i = 0; i<arr.Length;i++)
    {
        arr[i]= rnd.Next(0,1000);
    }
}

void Proverka(int[] args)
{
    int a =0;
    for(int i=0;i<args.Length;i++)
    {
        if(args[i]>98 || args[i]<10)
        {

        }
        else
        {
            a+=1;
        }
    }
    System.Console.WriteLine(a);
}

System.Console.WriteLine("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

MAS(mas);
System.Console.WriteLine("["+string.Join(", ", mas) + "]");

Proverka(mas);
