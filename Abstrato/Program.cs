using System;

namespace Abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando

            PessoaFisica p = new PessoaFisica();
            p.taxadeEmprestimo(2000);

            PessoaJuridica p2 = new PessoaJuridica();
            p2.taxadeEmprestimo(5000);
        }
    }
}
