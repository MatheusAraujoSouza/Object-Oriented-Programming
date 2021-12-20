using System;

class Pessoa{
    //atributos
    public double peso;
    public double altura;
    //Metodos
    private double imc(double peso, double altura)
    {
        return peso/(altura*altura);
    }

    public void resultado()
    {
        double valor_do_imc = imc(peso,altura);
        
        if (valor_do_imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (valor_do_imc < 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if ( valor_do_imc < 30)
        {
            Console.WriteLine("Acima do peso.");
        }
        else if (valor_do_imc < 35)
        {
            Console.WriteLine("Obesidade do tipo I");
        }
        else if (valor_do_imc < 40){
            Console.WriteLine("Obesidade do tipo II");
        } 
        else
        {
            Console.WriteLine("Obesidade do tipo III");
        }
    }

}