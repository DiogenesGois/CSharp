using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2Ex3 {
    class Program {
        static void Main(string[] args) {
            string nome = "";
            float media = 0f;
            int aulas = 0;
            int numeroFaltas = 0;
            int percentagemFaltas = 0;
  

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a sua média?");
            media = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantas aulas teve?");
            aulas = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas faltas teve?");
            numeroFaltas = int.Parse(Console.ReadLine());

            percentagemFaltas = numeroFaltas * 100 / aulas;
           

            if (media >= 9.5 && percentagemFaltas < 25)
            {
                Console.WriteLine($"{nome} está aprovado com média {media} e {percentagemFaltas}% de faltas");
            } else
            {
                Console.WriteLine($"{nome} está reprovado com média {media} e {percentagemFaltas}% de faltas");
            }


            Console.ReadKey();
        }
    }
}
