using System;

namespace aula04{
    class Program{
        static void Main(){
            //Tipos de declaração de arrays 
            int[] n = new int[4];
            int[] num = {40,12,339};
            int[] n2 = new int[5]{0,0,0,0,0};
            Console.WriteLine(num[2]);
            Console.WriteLine(n2[4]);

            //Arrays bidimencionais
            int[,] n4 = new int[2,2]{{2,5},{6,7}};//Primeira maneira de declaracao
            int[,] n5 = new int[2,3];
            n5[1,1] = 0;
            Console.WriteLine(n4[0,0]);
            Console.WriteLine(n5[1,1]);

            //Usando loop para printar o vetor e logo depois a matrix 
            for(int i=0;i<3;i++){//printando o vetor num
                Console.Write(num[i]+" ");
            }
            Console.Write("\n");
            
            for(int i=0;i<5;i++){//printando o vetor n5
                Console.Write(n2[i]+" ");
            }
            Console.Write("\n");
            
            for(int i=0;i<2;i++){//printando a matriz n4
                for(int j=0;j<2;j++){
                    Console.Write(n4[i,j]+" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //Usando a forma de While que executa enquanto a condicao ser verdadeira
            int jj=0;
            while(jj<3){
                Console.Write(num[jj]+" ");
                jj++;
            }
            Console.Write("\n");

            //DO - While
            //Praticando co uma senha 
            string senha = "10203040Deus";
            string senha_User;
            do{
                //Console.Clear();
                Console.Write("Digite a senha de segurança: ");
                senha_User = Console.ReadLine();
                
                if(senha_User != senha){
                    Console.Write("Senha incorreta");
                    Console.ReadLine();
                    Console.Clear();
                }else{
                    break;
                }

            }while(true);



            //FOREACH 
            int contador=0;
            foreach(int i in n4){//Lendo uma matriz com um único loop
                Console.Write(i+" ");
                contador++;
                if(contador == 2){
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
        }
    }
}
