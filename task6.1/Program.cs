// 39 Напишите программу, которая перевернёт одномерный массив ( последний элемент булет на первом месте, а первый - на последнем и т.д.
//[ 1 2 3 4 5 ] -> [5 4 3 2 1 ]
//[6 7 3 6 ] - > [6 3 7 6]

void FillArray (int[] arr)
{
    Random rnd = new Random();
    for (int i =0; i<arr.Length;i++)
    {
        arr[i]=rnd.Next(1,10);
    }
    System.Console.WriteLine("["+string.Join(", ", arr)+"]");
}

void Reverse(int[] arr)
{
    int temp=0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        temp=arr[i];
        arr[i]= arr[arr.Length-i-1];
        arr[arr.Length-1-i]=temp;
    }
    System.Console.WriteLine("["+string.Join(", ", arr)+"]");
}

System.Console.WriteLine("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

FillArray(mas);
System.Console.WriteLine(mas);

Reverse(mas);
System.Console.WriteLine(mas);

//Вариант решения №2
//int[] arr = new int[n];

//for(int i =0; i<arr.Length;i++)
//    {
 //       arr[i]=mas[mas.Length-i-1];
 //   }
//System.Console.WriteLine("["+string.Join(", ", arr)+"]");