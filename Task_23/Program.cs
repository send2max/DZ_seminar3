// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


while (true)
{
 Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
if(n>0)
{
    Console.WriteLine("____________");
    Console.WriteLine("x | x^3");
    Console.WriteLine("____________");
    for (int i =1; i<=n; i++)
    {
       Console.WriteLine($"{i} | {i*i*i} "); 
    }
    Console.WriteLine("____________");
    break;
}
else
{
   Console.WriteLine("Введите положительное число: "); 
   continue;
}
}
