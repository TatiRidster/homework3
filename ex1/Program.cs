// проверка на палиндром

void Palindrom(int num)
{    
    if (num / 1000 == (num % 10) * 10 + (num % 100) / 10)
     { 
        Console.WriteLine("Это палиндром");
     }
    else
    {
        Console.WriteLine("Это не палиндром");  
    }
    return;
}
    Console.WriteLine("Введите пятизначное число");
    int num = Convert.ToInt32(Console.ReadLine());
    Palindrom(num);