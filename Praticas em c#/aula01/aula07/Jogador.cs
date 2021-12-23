
static class Jogador{//quando uma classe static é criada tudo precisa ser static dentro dele
    static public string name;
    static public int id;
    static public bool alerta_player;
    //Criando metodos
    static public void informacao_do_jogador(string namee, bool alerta_playerr, int idd){
       if(name == null){//Fazendo com que tenha sempre um unico jogador no jogo. 
            name = namee;//Não é possível usar this para referenciar static métodos ou acessadores de propriedade.
            alerta_player=  alerta_playerr;
            id = idd;
        }
        
    }


}