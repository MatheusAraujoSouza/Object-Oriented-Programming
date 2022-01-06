using System;
class Moto : Veiculo {
    private bool status_multa;
    public Moto(bool status_multa) : base(123456,"Golf","O teste foi realizado"){
        this.status_multa = status_multa;
    }

    public void status_damulta(){
       Console.WriteLine("O status de multa para a moto é {0}",status_multa); 
    }
    
} 