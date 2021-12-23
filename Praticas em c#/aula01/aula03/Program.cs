using System;

namespace aula03
{
    class Program
    {
        static void Main()
        {
            //Lendo o numero do usuario
            Console.Write("Digite um valor inteiro n : ");
            int n = int.Parse(Console.ReadLine());
        
            //IF/ELSE IF/ElSE 
            

            if(n < 45){
                Console.WriteLine("Reprovado por ser < 45");
            }
            else if (n < 49)
            {
                Console.WriteLine("Reprovado por ser < 49");
            }
            else if(n < 60)
            {
                 Console.WriteLine("Exame por ser < 60");
            }else
            {
                Console.WriteLine("Aprovado");
            }

            //Segundo teste de ifs alinhados

            if(n >=60){
                if(n>=90){
                    Console.WriteLine("Aprovado com meritos");
                }else{
                    Console.WriteLine("Apenas aprovado");
                }
            }
            else{
                if(n < 45){
                    Console.WriteLine("Reprovado por nota");
                }else{
                    Console.WriteLine("Exame");
                }
            }

            inicio:
      
            //SWITCH
            
            Console.WriteLine("Digite um caractere para indicar o meio de transporte");
            Console.WriteLine("Onibus[o], Carro[c], Bicicleta[b], Avião[a] ");
            char character = Convert.ToChar(Console.ReadLine());
            switch(character){
                case 'a':
                case 'A':
                    Console.WriteLine("O preço da passagem de aviao para seu destino é R$: 4000");
                    break;
                case 'o':
                case 'O':
                    Console.WriteLine("O preço da passagem de onibus para seu destino é R$: 500");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("O preço da passagem de carro para seu destino é R$: 470");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("Boa sorte!!");
                    break;
                default:
                    Console.WriteLine("letra digitada incorreta");
                    break;

            }
            Console.Write("Deseja consultar outro meio de transporte s < > n? :");
            char resp = Convert.ToChar(Console.ReadLine());
            if(resp == '<'){
                Console.Clear();
                goto inicio;
            }
            //goto inicio;


        }
    }
}
