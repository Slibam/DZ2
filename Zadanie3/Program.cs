//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите 5ое число: ");
int number     = Convert.ToInt32(Console.ReadLine());
int digitIndex = 0;
int perv = number.ToString()[digitIndex] - '0';
Console.WriteLine ("первая цифра " + perv);
digitIndex = 1;
int vtor = number.ToString()[digitIndex] - '0';
Console.WriteLine ("вторая цифра " + vtor);
digitIndex = 3;
int tret = number.ToString()[digitIndex] - '0';
Console.WriteLine ("четвёртая цифра " + tret);
digitIndex = 4;
int xhet = number.ToString()[digitIndex] - '0';
Console.WriteLine ("пятая цифра " + xhet);
if (perv == xhet)
{
   if (vtor == tret)
   {
    Console.WriteLine ("Чисто полиндромное ( 1ая цифра соответствует 4ой и 2ая соответствует 3ей)");
   }
}
else 
{
Console.WriteLine ("Чисто не полиндром");
}