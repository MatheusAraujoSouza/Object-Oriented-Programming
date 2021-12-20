using System;

class Aluno
{

    //Atributos
    private double nota1, nota2;

    //Metodos
    private double media()
    {
        return Math.Sqrt(nota1 * nota2);
    }

    public void mensagem()
    {
        Console.WriteLine("Digite os valores da p1 : ");
        nota1 =  Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite os valores da p2 : ");
        nota2 =  Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("O valor da média geometrica é : "+media());
    }
}