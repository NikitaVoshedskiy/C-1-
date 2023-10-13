// 42 напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

void GetBinareView(int N)
{
    if(N == 0)
    {
        return;
    }
    GetBinareView(N/2);
    System.Console.Write(N%2);

}

System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
GetBinareView(N);