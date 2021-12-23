using System;

namespace aula01
{
    class Program
    {

        static int num4 = 30;//Criando uma variavel global ao metodo Main
        static void Main()
        {
            //variaveis 
            int num1,num2,num3;
            num1 = 2;
            num2 = 5;
            Console.WriteLine(num1+num2); 
            Console.WriteLine(num1+num2 - num4); 
            
            //operadores de atribuicao
            float n1,n2,n3;
            n1=23.4f;
            n2=5.5f;
            n3=((n1-n2)*n1) % n2;
            Console.WriteLine(n3); 
            n1 = n1*n1;
            Console.WriteLine(n1);
            Console.WriteLine("o valor da variavel n1: "+n1+" e o valor na n2: "+n2);

            //Operadores logicos
            // >< , >= <= && || != ==  
            //more in https://www.tutorialsteacher.com/csharp/csharp-operators
            bool resp = (5 < 4);
            bool resp2 = (5 < 4) || (4 < 5);
            bool resp3 = (5 < 4) && (4 < 5);
            bool resp4 = 5 != 4;
            Console.WriteLine(" 5 < 4 :"+resp+" (5 < 4) or (4 < 5): "+resp2+" (5 < 4) and (4 < 5): "+resp3+" 5 != 4 "+resp4);
            Console.WriteLine(" 5 < 4 :{0} , (5 < 4) or (4 < 5):{1} , (5 < 4) and (4 < 5):{2} 5 != 4 :{3}",resp,resp2,resp3,resp4);
            Console.WriteLine(" 5 < 4 :{0} ,\n (5 < 4) or (4 < 5):{1} , \n(5 < 4) and (4 < 5):{2} \n5 != 4 :{3}",resp,resp2,resp3,resp4);
       
            //Outros tipos de formatação
            double Lucro = 0.3;
            double valorvenda;
            double valorcompra = 500.00;
            string produto ="Tenis";
            valorvenda = (valorcompra)+ valorcompra * Lucro;
            Console.WriteLine("Produto {0,15}",produto);
            Console.WriteLine("Valor da compra {0,15:c}",valorcompra);  
            Console.WriteLine("Lucro {0,15:p}",Lucro);  
            Console.WriteLine("Valor da venda {0,15:c}",valorvenda);         
       
        }
    }
    
}