using System;

namespace aula08{
    class Program{
        static void Main(){
            //instanciando 
            Carro c1 = new Carro(12.523);
            c1.status_atual_do_veiculo();
            
            Console.WriteLine(c1.getValorcarro());
            c1.qualquer_nome = "Porque ele foi recebido atravez de herança.";
            Console.WriteLine(c1.qualquer_nome);
            double resultado = c1.getValorcarro();
            Console.WriteLine(resultado);
            int resp = c1.calculasoma3(5,6);
            
        }
    }
}
