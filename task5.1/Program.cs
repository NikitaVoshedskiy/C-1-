// задайте масси из N элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void FillArray (int[] arr)
{
    Random rnd = new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]= rnd.Next(-9, 10);
    }
}


System.Console.WriteLine("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[size];
int sumPositive = 0;
int sumNegative = 0;

FillArray(mas);
System.Console.WriteLine(string.Join(", ", mas));

for (int i =0; i<mas.Length;i++)
{
    if (mas[i] >0 )
    {
        sumPositive+= mas[i];
    }
    else
    {
        sumNegative+=mas[i];
    }
}

System.Console.WriteLine(sumNegative);
System.Console.WriteLine(sumPositive);