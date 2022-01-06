using System;

class Usuario:Hkk{

    private string name_user;
    private string name;
    

    public Usuario(){
        name_user = "Matheus Araujo SOuza";
    }

    public string vm{
        get{return name_user;}

        set{name_user = value;}
    }

    public string Name{
        get{return name;}
        set{name = value ;}
    }


}