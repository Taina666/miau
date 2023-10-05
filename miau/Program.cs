using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite um numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = num + num2;
        Console.WriteLine($"resutado {result}");
        Console.ReadKey();

        if (num2 > num) Console.WriteLine($"O numero {num2} é maior");


    }
}