// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Write("Введите число N");
int N = int.Parse(Console.ReadLine()!);
string VyvodCubov(int N)
{
    String res = "";
    int i =1;
    while (i<=N)
    {
        String res1 = ((Math.Pow(i,3))+",");
        res = res + res1;
        i=i+1;
    }
return res=res[..^1];
}
Console.WriteLine(VyvodCubov(N));