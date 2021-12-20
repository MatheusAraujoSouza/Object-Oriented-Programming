using System;

class Colaborador : Pessoa
{   
    //Atributos
    private double salario;
    //Metodo construtor
    public Colaborador(string name,int idade,double salario)
    {
        this.name = name;
        this.idade = idade;
        this.salario = salario;

        menssagem();
        mensagem_colaborador();
    }


    private void mensagem_colaborador()
    {
        Console.WriteLine("O nome é "+name+" e a idade é "+idade+ " o salario "+salario);
    }


}