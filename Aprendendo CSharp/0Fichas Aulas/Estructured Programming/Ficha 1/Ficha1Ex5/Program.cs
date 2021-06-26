using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1Ex5 {
    class Program {
        static void Main(string[] args) {
            int eleitores = 0;
            int votosBrancos = 0;
            int votosNulos = 0;
            int votosValidos = 0;

            Console.WriteLine("Insira o numero de eleitores");
            eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de votos brancos");
            votosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de votos nulos");
            votosNulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de votos validos");
            votosValidos = int.Parse(Console.ReadLine());

            Console.WriteLine("A percetagem de votos brancos é: " + (votosBrancos * 100 / eleitores) + "%");
            Console.WriteLine("A percetagem de votos nulos é: " + (votosNulos * 100 / eleitores) + "%");
            Console.WriteLine("A percetagem de votos válidos é: " + (votosValidos * 100 / eleitores) + "%");

            Console.ReadKey();
        }
    }
}
