
using System; 

namespace Exercicio_massa_corporal
{

    class Program
    {
        static void Main(string[] args)
        {
            //instanciando ou criando o objeto
            Pessoa nova = new Pessoa();
            nova.altura = 1.80;
            nova.peso = 80;
            nova.resultado();
        }

    }

}
