using System;


class Aluno{
    //Atributos
    public string nome;
    public double nota_p1, nota_p2;

    //Metodos
    public double media()
    {
        return ( nota_p1 + nota_p2 )/2;
    }

    public string analise(double media)
    {
        return media >= 7 ? "Aprovado" : "reprovado"; 
    }

    public void resultado()

    {
        double obtermedia = media();//Obtendo a media
        string obterinforesult = analise(obtermedia);//obtendo informacao da situacao
        Console.WriteLine("O aluno "+nome+ " foi "+obterinforesult);
    }

}