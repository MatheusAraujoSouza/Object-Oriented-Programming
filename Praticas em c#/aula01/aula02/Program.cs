using System;

namespace aula02
{
    class Program
    {
        enum Dias_da_semana{Segunda, Terça, Quarta, Quinta,Sexta,Sábado,Domingo};
        static void Main()
        {
            //Lendo informações do usuario
            int v1,v2;
            Console.Write("Digite o valor da primeira variavel: ");
            v1= Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o valor da primeira segunda: ");
            v2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O valor do produto das variaveis é :{0}",(v1*v2));


            //Operação de BitWise 
            int num1 = 2,num2=2;
            //Ao realizar o bitwise vai ocorrer umd eslocamento a a esquerda e o valor vazio vai para ser zero
            num1 = num1 <<1;//o que era 00000010 vai para 0000100
            Console.WriteLine(num1);
            num2 = num2 << 2;//o bitwise vai fazer com que o valor dobre duas vezes 00000010 vai para 00001000
            Console.WriteLine(num2);
            num2 = num2 >> 2; // lo bitwise vai fazer com o que o valor diminua pela metade duas vezes
            Console.WriteLine(num2);
            
            //Enum, com o enum podemos referenciar os valores que o conjunto pode assumir 
            //com os index dele
            
            Dias_da_semana p = Dias_da_semana.Segunda;
            Console.WriteLine(p);
            //Tambem é possivel passar o index
            p = (Dias_da_semana)2;
            Console.WriteLine(p);
            //também é possivel transformar o valor em index
            int index = (int)Dias_da_semana.Segunda;
            Console.WriteLine(index);




        }
    }
}
