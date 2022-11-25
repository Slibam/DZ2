//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int qd; 
int i = 1;
while (i <=num)
    {
    qd = (i*i*i);
    Console.Write($"{qd},");
    i += 1;
    }