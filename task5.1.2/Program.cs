// Вариант 2 когда void возвращает значение

void FillArray (int[] arr)
{
    Random rnd = new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]= rnd.Next(-9, 10);
    }
}

void SumPandN (int[] arr, out int sumNegative, out int sumPositive)
{sumNegative = 0;
sumPositive = 0;
    for (int i =0; i<arr.Length;i++)
{
    if (arr[i] >0 )
    {
        sumPositive+= arr[i];
    }
    else
    {
        sumNegative+=arr[i];
    }
}
}

System.Console.WriteLine("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[size];


FillArray(mas);
System.Console.WriteLine(string.Join(", ", mas));

SumPandN(mas, out int sumN, out int sumP);
System.Console.WriteLine(sumN);
System.Console.WriteLine(sumP);