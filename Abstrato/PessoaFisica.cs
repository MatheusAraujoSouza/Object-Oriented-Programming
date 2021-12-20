using System;

class PessoaFisica : Abs2
{
    //Metodo obrigatorio obrigatodio
    public override void taxadeEmprestimo(double emprestimo)
    {
        Console.WriteLine("A taxa de emprestimo para pessoa Fisica vai ser "+(emprestimo * 0.1));
    }



}