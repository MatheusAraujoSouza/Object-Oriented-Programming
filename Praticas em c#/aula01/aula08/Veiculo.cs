using System;

class Veiculo{
    //Atributos
    public string qualquer_nome;
    private string test;
    private int placa;
    private string nome;
    private bool estatus;
    //Méotodo construtor 
    public Veiculo(int placa, string nome,string test){
        this.placa = placa;
        this.nome = nome;
        this.test = test;
        estatus = false;
    }
    //Outros métodos
    public void status_atual_do_veiculo(){
        Console.WriteLine("O estatos atual do carro é: {0} ",estatus);
    }
    public void getTest(){
        if(test != "0"){
            Console.WriteLine("O valor do teste : {0}",test);
        }
        
    }  


    protected void calculasoma(int num1, int num2){
        Console.WriteLine("O valor da soma é "+ (num1+num2));
    } 


    private void calculasoma2(int num1, int num2){
        Console.WriteLine("O valor da soma pelo calculo privado é "+ (num1+num2));
    } 

    
    internal int calculasoma3(int num1, int num2){
        return num1+num2;
      
    } 

    
}