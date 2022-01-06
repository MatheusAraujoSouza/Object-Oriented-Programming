using System;

class Aluno : Estudante{
    protected int numerodefaltas;
    public Aluno(int numerodefaltas) : base("Matheus Araujo Souza", 26){
        this.numerodefaltas = numerodefaltas;
    }
    

    override public void info(int horasdeaula, string name){
        Console.WriteLine("A quantidade total de horas de aula do aluno {0} é {1}", this.name,horasdeaula);
    }
}