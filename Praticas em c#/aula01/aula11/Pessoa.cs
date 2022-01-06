using System;


class Pessoa{
    //Atributos
    private int p_id;
    private string p_nome;
    private short p_idade;
    private char p_sexo;

    public Pessoa(){}

    public Pessoa(int p_id, string p_nome, short p_idade, char p_sexo)
    {
        this.p_id    = p_id;
        this.p_nome  = p_nome;
        this.p_idade = p_idade;
        this.p_sexo  = p_sexo;
    }


    public void setId(int p_id){
        this.p_id = p_id;
    }

    public int getId(){
        return p_id;
    }




}