using System;

namespace aula05{
    class Program{
        static void Main(){


            //Métodos para array

            //Declarando os arrays 
            int [] vet1 = new int[100];
            int [] vet2 = new int[100];
            int [] vet3 = new int[100];
            int [,] matriz = new int[2,5]{{12,54,54,65,23},{456,65,23,556,98}};
            int[] vet_test = {1,2,3,4,5,6,7,8,9,10};

            //Gerando numeros randomicos
            /*
            The Next() Method of System.
            Random class in C# is used to get a random integer number. 
            This method can be overloaded by passing different parameters
            */
            Random rand = new Random();
            for(int i=0;i<100;i++){
                vet1[i]=rand.Next(0,100);
            }
            Console.WriteLine("Elementos do vetor 1");
            foreach(int i in vet1){
                Console.Write(i+" ");
            }
            Console.Write("\n");

            Array.Sort(vet1);

            Console.WriteLine("Print do vetor ordenado");
            foreach(int i in vet1){
                Console.Write(i+" ");
            }
            Console.WriteLine();
            //public static int BinarySearch(arry, valor)
            Console.WriteLine("BinarySearch");
            int valor_procurado = 3;
            int pos = Array.BinarySearch(vet1,valor_procurado);
            Console.WriteLine("A posicao do elemento {0} é : {1} ",valor_procurado,pos);

            pos = Array.BinarySearch(vet_test,valor_procurado);
            Console.WriteLine("A posicao do elemento {0} é : {1} ",valor_procurado,pos);

            //public static void Copy(Array origem, array destino, quantidade de elementos)
            Console.WriteLine("Função Copy");
            Array.Copy(vet1,vet2,vet1.Length);

            foreach(int i in vet2){
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //public void CopyTo(Array destino, a partir dessa posicao)
            Console.WriteLine("CopoyTo");
            vet2.CopyTo(vet3,0);
            foreach(int i in vet3){
                Console.Write(i+" ");
            }
            Console.Write("\n");

            //public long Getlonglength(Dimensão)
            Console.WriteLine("Getlonglength");
            long quantidade_de_elementos_no_vetor=vet1.GetLongLength(0);
            Console.WriteLine("A quantidade de elementos no vetor é {0}",quantidade_de_elementos_no_vetor);





            //public int GetlowerBound(Dimensão)
            Console.WriteLine("GetlowerBound");
            int Menor_indice_do_vetor=vet1.GetLowerBound(0);
            int Menor_indice_da_matriz=matriz.GetLowerBound(1);
            Console.WriteLine("A quantidade de elementos no vetor : {0} e a \n quantidade de elementos na matriz: {1}",Menor_indice_do_vetor,Menor_indice_da_matriz);


            //public int GetUpperBound(Dimensão)
            Console.WriteLine("GetUpperBound");
            int Maior_indice_do_vetor = vet1.GetUpperBound(0);
            int Maior_indice_da_matriz = matriz.GetUpperBound(1);
            Console.WriteLine("O maior indice do vetor: {0} e o menor indice da matriz {1}",Maior_indice_do_vetor,Maior_indice_da_matriz);

            //get Value, basicamente ele vai me retornar o valor está na posicao do indice dado 
            Console.WriteLine("Getvalue");
            int valor0 = Convert.ToInt32(vet1.GetValue(3));
            int valor1= Convert.ToInt32(matriz.GetValue(1,2));
            Console.WriteLine("Os valores no index 3 : {0} e o valor no index [1,2]: {1}",valor0,valor1);

            int[] vet_testt = {1,2,3,4,6,7,8,3};
            //public static indexoF(array, valor)
            Console.WriteLine("indexpf");
            int indece1 = Array.IndexOf(vet_testt,3);
            Console.WriteLine("Indece do primeiro valor 3 : {0}", indece1);

            
            //public static indexlast
            Console.WriteLine("idenxlast");
            int indece2 = Array.LastIndexOf(vet_testt,3);
            Console.WriteLine("O ultimo elemento que paarece o index: {0}",indece2);


            //public static void Reverse(array)
            Array.Reverse(vet1);
            foreach(int i in vet1){
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //Metodo Set value 
            int[] vetor44 = {23,5,6,7,8};
            vetor44.SetValue(1900,0);
            foreach(int i in vetor44){
                Console.Write(i+" ");
            }
            Console.WriteLine();











        }
    }
}
