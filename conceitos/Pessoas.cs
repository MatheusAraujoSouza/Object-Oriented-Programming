using System;

class Pessoas
{
    //Atributos
    public string nome;
    public int idade;

    //Metodos
    public void mensagem()
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" anos.");
    }

    //Overload de Métodos
    public void apresentar(){
        Console.WriteLine("Olá");
    }
    public void apresentar(string nome){
        Console.WriteLine("Olá o seu nome é "+ nome);
    }
    public void apresentar(string nome, int idade){
        Console.WriteLine("Olá o seu nome é "+nome+" e a sua idade é "+idade);
    }

}