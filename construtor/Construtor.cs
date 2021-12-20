using System;


class Construtor{

    public Construtor(int idade)
    {
        Console.WriteLine("Ola a idade media das pessoas e' " + idade);
    }

    public Construtor(string nome)
    {
        Console.WriteLine("O nome do usuario é " + nome);
    }

    public Construtor(string nome, int idade )
    {
        Console.WriteLine("O nome do usuario é " + nome+  " com a seguinte idade de "+idade);
    }



}