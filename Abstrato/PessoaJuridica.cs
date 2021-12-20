using System;

class PessoaJuridica : Abs2
{
    //Metodo obrigatorio obrigatodio
    public override void taxadeEmprestimo(double emprestimo)
    {
        Console.WriteLine("A taxa de emprestimo para pessoa juridica vai ser "+(emprestimo * 0.2));
    }



}