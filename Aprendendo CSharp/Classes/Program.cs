using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {

    public class Jogador {

        public int energia;
        public bool vivo;
        public string name;

        public Jogador() {
            energia = 100;
            vivo = true;
            name = "joao";

        }

        public Jogador(string n, bool v) {
            energia = 100;
            vivo = true;
            name = n;

        }

        public Jogador(string n, bool vivo, int ener) {
            energia = ener;
            vivo = true;
            name = n;

        }


        public void info() {
            Console.WriteLine("Energia jogador: {0}", energia);
            Console.WriteLine("Estado do jogador: {0}", vivo);
            Console.WriteLine("Nome do jogador: {0} \n", name);

        }


        ~Jogador() {
            System.Diagnostics.Trace.WriteLine($"O jogador {name} foi destruido");
        }

    }

    class Program {
        static void Main(string[] args) {

            string nome1;
            int ener = 0;
            bool vivo = true;

            Console.WriteLine("Indique o nome do jogador");
            nome1 = Console.ReadLine();

            Console.WriteLine("Indique a energia do jogador");
            ener = int.Parse(Console.ReadLine());

            if (ener == 0)
            {
                vivo = false;
            }

            //Jogador j1 = new Jogador();
            //Jogador j1 = new Jogador();
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador(nome1, true);
            Jogador j3 = new Jogador(nome1, vivo, ener);
            //j1.energia = 50;
            //j2.energia = 30;


            j1.info();
            j2.info();
            j3.info();



            Console.ReadKey();
        }
    }
}
