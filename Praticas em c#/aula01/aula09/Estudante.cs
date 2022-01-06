using System;

abstract class Estudante{
    protected string name;
    protected int idade;
    protected float tamanho;
    protected string location;
    public string outronome;
    //Métodos
    public Estudante(string name, int idade){
        this.name = name;
        this.idade = idade;
    }

    abstract public void info(int horasdeaula, string name);
}