using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Telas;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes= 0;
            while (opcoes != 5)
            {
                Console.WriteLine("----------MENU----------");
                Console.WriteLine("O que deseja fazer?\n1 - Cadastrar Cliente\n2 - Listar Cliente\n3 - Cadastrar Funcionário\n4 - Listar Funcionário\n5 - Sair");
                opcoes = int.Parse(Console.ReadLine());

                ManterCliente telaCliente = new ManterCliente();
                ManterFuncionario telaFuncionario = new ManterFuncionario();

                switch (opcoes)
                {
                    case 1:
                        telaCliente.CadastrarCliente();
                        break;
                    case 2:
                        telaCliente.ListarClientes();
                        break;
                    case 3:
                        telaFuncionario.CadastrarFuncionario();
                        break;
                    case 4:
                        telaFuncionario.ListarFuncionarios();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Comando não encontrado!");
                        break;
                }
            }
        }
    }
}
