using System;

class Bots{
    //Atributos
    static public bool alerta;
    public string name_bots;
    //Métodos
    //Documentação do método construtor https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/constructors
    public Bots(string name_bots){//Método construtor
        this.name_bots = name_bots;
        alerta = false;
    }
    public double Quadrado(double num1,double num2){
        Console.WriteLine("Entrou no do double");
        return num1*num2;
    }
    public int Quadrado(int num1,int num2){
        Console.WriteLine("Entrou no do int");
        return num1*num2;
    }

    public void estado_de_alerta(){
        Console.WriteLine("O estado de alerta do bot é {0}",alerta);
    }

}