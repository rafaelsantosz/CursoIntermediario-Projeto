using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Bibliotecaa.Arquivo;
using Projeto.Conversores;

namespace Projeto.Telas
{
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();
            Console.Clear();

            Console.WriteLine("----------CADASTRAR CLIENTE----------");

            Console.WriteLine("Digite o Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Data de Nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.WriteLine("Digite o RG: ");
            cliente.RG = Console.ReadLine();

            Console.WriteLine("Digite o CEP: (Apenas números!)");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.WriteLine("Digite a Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.WriteLine("Digite o Endereco: ");
            cliente.Endereco = Console.ReadLine();

            GerenciadorArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));
        }

        public void ListarClientes()
        {
            Console.Clear();

            Console.WriteLine("----------LISTAGEM DE CLIENTES----------");

            string[] linhas = GerenciadorArquivo.lerArquivo("cliente");

            foreach (string linha in linhas)
            {
                Cliente cliente = Conversores.ClienteTexto.ConverterParaCliente(linha);
                Console.WriteLine("NOME: "+cliente.Nome);
            }
        }
    }
}
