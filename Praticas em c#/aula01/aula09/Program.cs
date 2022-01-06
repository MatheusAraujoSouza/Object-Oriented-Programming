using System;

namespace aula09{
    class Program{
        static void Main(){
            Aluno a1 = new Aluno(12);
            a1.info(400,"Pedro");
            a1.outronome = "Matheus Araujo SOuza";
            Console.WriteLine(a1.outronome);
            Aluno e = new Aluno(5);
            e.outronome = "Joao";
            Console.WriteLine(e.outronome);


        }
    }
}
