using System;

namespace _conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando objeto
            Pessoas novo = new Pessoas();
            novo.nome = "Matheus Araujo Souza";
            novo.idade = 26;
            novo.mensagem();
            //Aqui nesses Métodos exite um overload 
            novo.apresentar();
            novo.apresentar(novo.nome);
            novo.apresentar(novo.nome, novo.idade);

        }
    }

}