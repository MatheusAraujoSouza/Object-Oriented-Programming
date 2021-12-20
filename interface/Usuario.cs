using System;

class Usuario : IPadrao
{
    public void Soma(int n1,int n2)
    {
        Console.WriteLine(n1+n2);
    }
    public void Subtrair(int n1,int n2)
    {
        Console.WriteLine( n1 - n2);
    }
    public void Resto(int n1, int n2)
    {
        Console.WriteLine(n1 % n2);
    }
    public void Produto(int n1, int n2)
    {
        Console.WriteLine(n1 * n2);
    }
}