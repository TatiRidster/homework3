// Напишите программу, 
//которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >0)
{

Console.Write($"Кубы чисел от 1 до {number}: ");

       for (int i=1;i<=number;i++)
       {
          int result = i*i*i;
          Console.Write(result);
          if (i<=number -1)
          {
          Console.Write(", ");
          }
       }  
}
else
{
   Console.WriteLine($"Кубы чисел от 1 до {number}: ");
   for (int i=1; i>=number; i=i-1)
   {
      int result = i*i*i;
      Console.Write(result);
      if (i>=number +1)
      {
         Console.Write(", ");
      }
   }
}
