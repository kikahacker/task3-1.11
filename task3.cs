Console.WriteLine("Введите начало координат a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало координат b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение шага h");
int h = Convert.ToInt32(Console.ReadLine());
List<double> list = new List<double>();
double[] sa = new double[b];
/*for (int i = a; i <= b; i += h)
{
    double z = Math.Cos(Math.Pow(i, 2)) + Math.Pow(Math.Sin(i), 2);
    list.Add(z);
}*/
int kis = 0;
int v = 0;
double[] lis = list.ToArray();

/*for (int i = 1; i < lis.Length; i++)
{
    if ((lis[i] > 0 & lis[i-1] < 0)||(lis[i] < 0 & lis[i - 1] > 0))
    {
        kis++;
    }
}*/



for (int i = 0; i < b; i ++)
{
    for (int j = a; j <= b; j +=h)
    {
        double z = Math.Cos(Math.Pow(i, 2)) + Math.Pow(Math.Sin(i), 2);
        sa[i] = z;
        
    }
    Console.WriteLine(sa[i]);
    v++;
}
/*foreach (double d in lis)
{
    Console.WriteLine($"{d:F3}");
    v += 1;
}*/
for (int i = 1; i < sa.Length; i++)
{
    if ((sa[i] > 0 & sa[i - 1] < 0) || (sa[i] < 0 & sa[i - 1] > 0))
    {
        kis++;
    }
}



Console.WriteLine("Минимальное значение:");
//Console.WriteLine($"{list.Min():F3}");
Console.WriteLine($"{sa.Min():F3}");
Console.WriteLine("Максимальное значение:");
Console.WriteLine($"{sa.Max():F3}");
//Console.WriteLine($"{list.Max():F3}");
Console.WriteLine("Количество точек:");
Console.WriteLine(v);
Console.WriteLine("Количество раз когда функция меняет знак");
Console.WriteLine(kis);


