using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Curso3_Familia;

namespace Curso3_Familia
{
    public class Program
    {
        private static Casa casa;
        static void Main(string[] args)
        {
            bool opcao = false;
            do
            {
                Console.WriteLine("Digite o nome do responsavel da casa: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do responsavel da casa: ");
                var idade = int.Parse(Console.ReadLine());
                try
                {
                    casa = new Casa(new Responsavel(nome, idade));
                    opcao = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exceção lançada: {e.Message}");
                    continue;
                }

            } while (opcao == false);
            InstaciarTeste();
            int opcaoSelecionada;
            do
            {
                do
                {
                    opcaoSelecionada = ListarMenu();
                } while (opcaoSelecionada < 0 || opcaoSelecionada > 7);

                switch (opcaoSelecionada)
                {
                    case 1: // Cadastrar familia
                        CadastrarFamilia();
                        break;

                    case 2: // Cadastrar Tarefa
                        CadastrarTarefa();
                        break;

                    case 3: // Alterar dados cadastrados
                        AlterarDados();
                        break;

                    case 4: // Realizar Sorteio
                        casa.RealizarSorteio();
                        break;
                    case 5: // Printar tarefas
                        casa.PrintarLista();
                        break;

                    case 6: // Concluir tarefa
                        ConcluirTarefa();
                        break;

                    case 7: // Printar familia
                        casa.PrintarFamilia();
                        break;
                    case 0:
                        return;
                }
            } while (true);

        }

        private static void ConcluirTarefa()
        {
            Console.WriteLine("Digite seu nome: ");
            var nome = Console.ReadLine();
            Pessoa p = casa.ProcurarPessoa(nome);
            if(p == null)
            {
                Console.WriteLine("\nNome invalido");
                return;
            }
            p.Tarefa.Concluida = true;
        }

        private static void AlterarDados()
        {
            Console.WriteLine("Digite seu primeiro nome: ");
            var nome = Console.ReadLine();
            Pessoa p;
            int opcaoSelecionada;
            try
            {
                p = casa.ProcurarPessoa(nome);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceção lançada: {e.Message}");
                return;
            }
            Console.WriteLine("O que deseja alterar:\n" +
                             "(1). Nome Visivel\n" +
                             "(2). Idade\n" +
                             "(0). Sair\n" +
                             "Opcao: ");
            opcaoSelecionada = int.Parse(Console.ReadLine());
            switch (opcaoSelecionada)
            {
                case 1:
                    Console.WriteLine("Digite o novo nome: ");
                    p.Nome = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Digite a nova idade: ");
                    p.Idade = int.Parse(Console.ReadLine());
                    break;
            }
        }


        private static void CadastrarFamilia()
        {
            int opcaoSelecionada;
            do
            {
                string opcaoPessoa;
                do
                {
                    Console.WriteLine("Voce e (F) filho ou (R) responsavel? ");
                    opcaoPessoa = Console.ReadLine();
                    opcaoPessoa.ToUpper();
                } while (opcaoPessoa != "F" && opcaoPessoa != "R");

                Console.WriteLine("Digite seu nome: ");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade: ");
                var idade = int.Parse(Console.ReadLine());
                if (opcaoPessoa == "R")
                {
                    try
                    {
                        casa.adicionarPessoa(new Responsavel(nome, idade));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Exceção lançada: {e.Message}");
                    }
                }
                if (opcaoPessoa == "F")
                {
                    try
                    {
                        casa.adicionarPessoa(new Filhos(nome, idade));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Exceção lançada: {e.Message}");
                    }
                }
                Console.WriteLine("Deseja realizar outro cadastro? (1). Sim (0). Nao");
                opcaoSelecionada = int.Parse(Console.ReadLine());

            } while (opcaoSelecionada == 1);
        }

        private static void InstaciarTeste()
        {
            Responsavel mae = new Responsavel("Danielle", 39);
            Responsavel pai = new Responsavel("Vinicius", 37);
            casa.adicionarPessoa(mae);
            casa.adicionarPessoa(pai);
            casa.adicionarPessoa(new Filhos("Joao", 12, mae, pai));
            casa.adicionarPessoa(new Filhos("Maria", 10, mae, pai));

            casa.adicionarTarefa(new Tarefa("Banheiro"));
            casa.adicionarTarefa(new Tarefa("Cozinha"));
            casa.adicionarTarefa(new Tarefa("Quartos"));
            casa.adicionarTarefa(new Tarefa("Passar pano"));
        }

        public static void CadastrarTarefa()
        {
            string descricao;
            Console.WriteLine("Digite a descricao da tarefa: ");
            descricao = Console.ReadLine();
            try
            {
                casa.adicionarTarefa(new Tarefa(descricao));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceção lançada: {e.Message}");
            }
        }

        private static int ListarMenu()
        {
            int opcao;
            Console.WriteLine("\nDigite a opcao desejada: \n" +
                              "(1). Cadastrar Familia\n" +
                              "(2). Cadastrar Tarefa\n" +
                              "(3). Alterar dados cadastrados\n" +
                              "(4). Fazer sorteio das tarefas\n" +
                              "(5). Printar a lista de tarefas\n" +
                              "(6). Concluir Tarefa\n" +
                              "(7). Printar Familia\n" +
                              "(0). Sair\n" +
                              "Opcao: ");
            opcao = int.Parse(Console.ReadLine());  //Erro para letra
            return opcao;
        }
    }
}

