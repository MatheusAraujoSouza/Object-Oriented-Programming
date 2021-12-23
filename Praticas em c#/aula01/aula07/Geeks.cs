using System;
class Geeks {
 
    // calling another constructor
    // calls Geeks(string Name)
    // before Geeks()
    public string name;
    //Aplicando uma sobrecarga de construtores 
    /*
    public Geeks() : this("geeks")
    {
        Console.WriteLine("Non-Parameter Constructor Called");
        Console.WriteLine("No final por não ter nada ele vem aqui");
    }
    */
    public Geeks(){
        Console.WriteLine("É possivel criar varios tipos de construtores");
    }
    // Declare Parameter Constructor
    public Geeks(string name)
    {
        this.name=name;
        Console.WriteLine("Esse cara foi chamado");
        Console.WriteLine("Parameter Constructor Called");
        Console.WriteLine(name);
    }
}