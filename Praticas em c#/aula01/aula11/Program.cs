using System;

namespace aula10{
    class Program{
        static void Main(){
            List<string> carros = new List<string>();


            Usuario u = new Usuario();
            Console.WriteLine(u.vm);

            u.Name = "João pedro";
            Console.WriteLine(u.Name);
            u.uuu = "auhauha";
            object b = 12.4566;
            Console.WriteLine(b);
            
        }
    }


}