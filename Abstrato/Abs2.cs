using System;

abstract class Abs2
{
    //Metodo obrigatorio obrigatodio
    public abstract void taxadeEmprestimo(double emprestimo);

    //Metodo não obrigatodio
    public void taxaFinanciamento(double emprestimo)
    {
        Console.WriteLine("O valor da taxa de financiamento "+ (emprestimo* 0.1));
    }


}