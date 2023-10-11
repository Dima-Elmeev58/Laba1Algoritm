{
    Console.WriteLine("Введите a");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите c");
    double c = Convert.ToDouble(Console.ReadLine());

    double p = 0.5 * (a + b + c);

    double h = 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a;

    Console.WriteLine("Height = " + h);
    Console.WriteLine();


}