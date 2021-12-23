using System;
/*
namespace aula06{
    class Program{
        static void Main(){
            Program n = new Program();
            n.olamundo();

            Helloworld();


            int resto,divisao, produto,num1=14,num2=7;
            produto = produto_resto_divisao(num1,num2,out resto,out divisao);
            Console.WriteLine("O valor do Produto:{0} resto:{1} divisao: {2}",produto,resto,divisao);
            int resultado_da_soma = soma(5);
            Console.WriteLine(resultado_da_soma);
        
        }

        private void olamundo(){
            Console.WriteLine("Ola mundo");
        }



        static void Helloworld(){
            Console.WriteLine("Hello, World!!");
        }


        static int produto_resto_divisao(int num1,int num2, out int resto, out int divisao){
            resto = num1 % num2;
            divisao = num1/num2;
            return num1*num2;
        }



        //metodo para soma dos elementos, quando você nao sabe a quantidade de elementos de 
        //entrada
        static int soma(params int[]n){
            if(n.Length < 1){
                Console.WriteLine("Não existe nada para ser somado");
                return 0;
            }else if(n.Length < 2 ){
                //Console.WriteLine(n[0]);
                return n[0];
            }else{
                int res =0;
                for(int i =0; i < n.Length;i++ ){
                    res+=n[i];
                }
                return res;
            }
        }
    }
}
*/

class Program{
    static void Main(){
        Program n = new Program();
        n.olamundo();

        Helloworld();


        int resto,divisao, produto,num1=14,num2=7;
        produto = produto_resto_divisao(num1,num2,out resto,out divisao);
        Console.WriteLine("O valor do Produto:{0} resto:{1} divisao: {2}",produto,resto,divisao);
        int resultado_da_soma = soma(5);
        Console.WriteLine(resultado_da_soma+"Nao precisa de namespace");
    
    }

    private void olamundo(){
        Console.WriteLine("Ola mundo");
    }



    static void Helloworld(){
        Console.WriteLine("Hello, World!!");
    }


    static int produto_resto_divisao(int num1,int num2, out int resto, out int divisao){
        resto = num1 % num2;
        divisao = num1/num2;
        return num1*num2;
    }



    //metodo para soma dos elementos, quando você nao sabe a quantidade de elementos de 
    //entrada
    static int soma(params int[]n){
        if(n.Length < 1){
            Console.WriteLine("Não existe nada para ser somado");
            return 0;
        }else if(n.Length < 2 ){
            //Console.WriteLine(n[0]);
            return n[0];
        }else{
            int res =0;
            for(int i =0; i < n.Length;i++ ){
                res+=n[i];
            }
            return res;
        }
    }
}