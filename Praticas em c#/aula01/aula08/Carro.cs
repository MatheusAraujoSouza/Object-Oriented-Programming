using System;

class Carro : Moto{
    private double valor_do_carro;
    public Carro(double valor_do_carro) : base(true){
        this.valor_do_carro = valor_do_carro;
    } 

    public double getValorcarro(){
    
        this.calculasoma(2,3);
        return valor_do_carro;
    }



    
}