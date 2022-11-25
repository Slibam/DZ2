//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void DZ3_1()
{
        Double rasstoanie = 0;
        Double x1 = Convert.ToDouble(Console.ReadLine());
        Double y1 = Convert.ToDouble(Console.ReadLine());
        Double z1 = Convert.ToDouble(Console.ReadLine());
        Double x2 = Convert.ToDouble(Console.ReadLine());
        Double y2 = Convert.ToDouble(Console.ReadLine());
        Double z2 = Convert.ToDouble(Console.ReadLine());
        /*
        Random rand = new Random();
        Double x1 = rand.Next(-10, 11);
        Double y1 = rand.Next(-10, 11);
        Double z1 = rand.Next(-10, 11);
        Double x2 = rand.Next(-10, 11);
        Double y2 = rand.Next(-10, 11);
        Double z2 = rand.Next(-10, 11);
        */
        Console.WriteLine($"A(x1{x1}, y1{y1}, z1{z1}, x2{x2}, y2{y2}, z2{z2})");
        rasstoanie = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"Расстояние между точками в пространстве равно {rasstoanie}");
        Console.ReadKey();
}
DZ3_1();