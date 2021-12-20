using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando
            Aluno novo = new Aluno();
            novo.Nome = "Matheus araujo Souza"; //Agora vou usar o setter
            Console.WriteLine(novo.Nome);// Assim estou usando um getter
        }
    }

}
