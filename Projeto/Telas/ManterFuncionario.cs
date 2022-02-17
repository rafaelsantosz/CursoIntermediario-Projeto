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
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            Console.Clear();

            Console.WriteLine("----------CADASTRAR FUNCIONÁRIO----------");

            Console.WriteLine("Digite o Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Data de Nascimento: ");
            funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.WriteLine("Digite o RG: ");
            funcionario.RG = Console.ReadLine();

            Console.WriteLine("Digite o CEP: (Apenas números!)");
            funcionario.CEP = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Estado: ");
            funcionario.Estado = Console.ReadLine();

            Console.WriteLine("Digite a Cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.WriteLine("Digite o Endereco: ");
            funcionario.Endereco = Console.ReadLine();

            Console.WriteLine("Digite o Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.WriteLine("Digite o Salário: ");
            funcionario.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Data de Contratação: ");
            funcionario.DataContratacao = DateTime.Parse(Console.ReadLine());

            GerenciadorArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));
        }

        public void ListarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("----------LISTAGEM DE FUNCIONÁRIOS----------");

            string[] linhas = GerenciadorArquivo.lerArquivo("funcionario");

            foreach (string linha in linhas)
            {
                Funcionario funcionario = Conversores.FuncionarioTexto.ConverterParaFuncionario(linha);
                Console.WriteLine("NOME: " + funcionario.Nome+" - Cargo: "+funcionario.Cargo);
            }
        }
    }
}
