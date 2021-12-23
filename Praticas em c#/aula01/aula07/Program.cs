/*
//------Classes e Objetos:---------------------------------------//

//      [ModificadorClasse] class NOME_DA_CLASSE
//      {
//      Variáveis / Propriedades/ Atributos 
//      [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
//      
//      Metodos
//      [EspecificadorAcesso] retorno NOME_METODO([arg1,...])
//      {
//      corpo do método
//      }
// }

//-------O QUE SÃO E APLICAÇÕES:-----------------------------------------------//

//      [ModificadorClasse]: Define a visibilidade da classe.
//      public: pública, sem restrição de visualização.
//      abstract: Classe-Base para outrsas classes, não podem ser instanciados a objetos desta classe
//      sealed: Classe não pode ser herdada
//      static: Classe não permite a instanciação de objetos e seus membros devem ser "static", em uma classe
//       static não é possivel ter construtores.
//---------------------------------------------------------------------------------------------------
//      [EspecificadorAcesso]: Onde um membro da classe pode ser acessado
//      public: pública, sem restrição de acesso.
//      private: Só podem ser acessados pela própria classe.
//      protected: Podem ser acessados na própria classe e nas classes derivadas
//      abstract: Os métodos não tem implementação somente os cabeçalhos
//      sealed: O método não pode ser redefinido.
//      virtual: O método pode ser redefinido em uma classe derivada.
//      static: o método pode ser chamado mesmo sem a instanciação de um objeto.
*/

using System;

namespace aula07{
    class Program{
        static void Main(){
            Jogador.informacao_do_jogador("Matheus Araujo Souza",false,923848);
            Jogador.informacao_do_jogador("Maria Giulia Martins",true,676898);
            Console.WriteLine(Jogador.name);

            //Trabalhando com os boots
            //instanciando os bots
            Bots b1 = new Bots("boot inicial");
            
            Bots b2 = new Bots("boot dois");
            
            b1.estado_de_alerta();
            b2.estado_de_alerta();
            Console.WriteLine();

            Bots.alerta = true;
            b1.estado_de_alerta();
            b2.estado_de_alerta();
        

            //Console.Clear();
            
            Maquina m = new Maquina();
            m.Outro = "Alguma coisa que eu queria colocar";
            Console.WriteLine(m.Outro);
            Console.WriteLine();
            m.setCarga(200);
            Console.WriteLine(m.getCarga());
            Console.WriteLine();
            Maquina m2 = new Maquina();
            m2.setCarga(19283);
            Console.WriteLine(m2.getCarga());

            Maquina.idade_da_maquina = 19;

            m.Alerta_de_idade();
            m2.Alerta_de_idade();
           


            Geeks obj = new Geeks("Massss também é possivel mandar aqui");


            

            Console.WriteLine(b1.Quadrado(12,5));
            

        }
    }
}