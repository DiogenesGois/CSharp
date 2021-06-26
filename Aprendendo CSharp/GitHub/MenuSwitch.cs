using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSwitch_Menu
{
    enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualizar}
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            do
            {
                Console.WriteLine("Selecione uma das opções abaixo");
                Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
                index = int.Parse(Console.ReadLine());
                Opcao selecao = (Opcao)index;

                switch (selecao)
                {
                    case Opcao.Criar:
                        Console.WriteLine("O que pretende criar?");
                        break;
                    case Opcao.Deletar:
                        Console.WriteLine("O que pretende deletar?");
                        break;
                    case Opcao.Editar:
                        Console.WriteLine("O que pretende editar?");
                        break;
                    case Opcao.Listar:
                        Console.WriteLine("O que pretende listar?");
                        break;
                    case Opcao.Atualizar:
                        Console.WriteLine("O que pretende atualizar?");
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada,adeus");
                        break;
                }
                Console.ReadKey();
            } while (index < 6);

            Console.ReadKey();
        }
    }
}
