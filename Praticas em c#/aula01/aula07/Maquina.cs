class Maquina{
    //Atributos da maquina

    static public string input="Meu nome não é Jon";
    private int Carga;
    private string outro;
    
    static public int idade_da_maquina;
    private string nome_da_maquina;

    //Metodos usados na maquina 
    public int getCarga(){
        return Carga;
    }
    public void setCarga(int Carga){
        this.Carga = Carga;
    }

    public string Outro{
        get{return outro;}
        set{outro=value;}
    }

    public void Alerta_de_idade(){
        Console.WriteLine("A idade da maquina {0}",idade_da_maquina);
    }



    




}