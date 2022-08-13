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
     Console.WriteLine("___________________");
    Console.WriteLine("число  \t куб числа ");
     Console.WriteLine("___________________");
    for (int i =1; i<=n; i++)
    {
       Console.WriteLine($"{i} \t  { Math.Pow(i, 3)} "); 
    }
    Console.WriteLine("___________________");
    break;
}
else
{
   Console.WriteLine("Введите положительное число: "); 
   continue;
}
}
