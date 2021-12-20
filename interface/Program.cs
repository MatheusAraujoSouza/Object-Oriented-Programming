using System;

namespace _interface_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando
            Usuario p = new Usuario();
            p.Resto(11,2);
            p.Soma(34,88);
            p.Produto(77,99);
            p.Subtrair(5,7);
        }
    }
    
}
