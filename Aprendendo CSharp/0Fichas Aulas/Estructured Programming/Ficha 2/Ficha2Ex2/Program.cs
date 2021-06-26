using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2Ex2 {
    class Program {
        static void Main(string[] args) {
            string nome = "";
            float nota1 = 0f;
            float nota2 = 0f;
            float nota3 = 0f;
            float nota4 = 0f;
            float media = 0f; 

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Insira a primeira nota");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a terceira nota");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quarta nota");
            nota4 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 6)
            {
                Console.WriteLine($"{nome} está aprovado com média de {media}");
            } else
            {
                Console.WriteLine($"{nome} está reprovado com média de {media}");
            }



            Console.ReadKey();
        }
    }
}
