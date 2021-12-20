using System;

class Metodos
{
    //Métodos estaticos
    public static void soma(double num1,double num2)
    {
        Console.WriteLine(num1 + num2);
    }

    public static void produto(double num1, double num2)
    {
        Console.WriteLine(num1 * num2);
    }

    public static void resto(double num1,double num2)
    {
        Console.WriteLine((num1 % num2));
    }



    public static double Mod (double n, double m)
    {
        return ((n % m) + m) % m;
    }

}