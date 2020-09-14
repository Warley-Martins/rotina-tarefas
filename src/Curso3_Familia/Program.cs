using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Curso3_Familia;

namespace Curso3_Familia
{
    public class Program
    {
        //public static Casa Casa { get; private set; }

        static void Main(string[] args)
        {
            String p1 = null, p2 = null;
            Console.WriteLine(Comparar(p1,p2));
            /*
            InstaciarTeste();

            int opcaoSelecionada;
            int opcaoSelecionada2;
            int idade;

            string nome;    //nome para login de alteracao de dados
            string nomeAlterado;
            string senha;   //senha para login de alteracao de dados
            string hobby;
            string opcaoPessoa;

            /do
            {
                do
                {
                    opcaoSelecionada = ListarMenu();
                } while (opcaoSelecionada < 0 || opcaoSelecionada > 7);

                switch (opcaoSelecionada)
                {
                    case 1:
                        do
                        {
                            do
                            {
                                Console.WriteLine("Voce e (F) filho ou (R) responsavel? ");
                                opcaoPessoa = Console.ReadLine();
                            } while (opcaoPessoa != "F" && opcaoPessoa != "R" && opcaoPessoa != "f" && opcaoPessoa != "r");

                            Console.WriteLine("Digite seu nome: ");
                            nome = Console.ReadLine();

                            Console.WriteLine("Digite sua idade: ");
                            idade = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite seu hobby favorito: ");
                            hobby = Console.ReadLine();

                            Console.WriteLine("Digite uma senha: ");
                            senha = Console.ReadLine();

                            Casa.adicionarPessoa(opcaoPessoa, nome, idade, hobby, senha);

                            Console.WriteLine("Deseja realizar outro cadastro? (1). Sim (0). Nao");
                            opcaoSelecionada2 = int.Parse(Console.ReadLine());

                        } while (opcaoSelecionada2 == 1);
                        break;

                    case 2:
                        Console.WriteLine("Resultado do cadastro: "
                                          + Casa.CadastrarTarefa(CadastrarTarefa()));
                        break;

                    case 3:

                        Console.WriteLine("Digite seu primeiro nome: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("Digite sua senha: ");
                        senha = Console.ReadLine();

                        if (Casa.VerificarPessoa(nome, senha) == true)
                        {
                            for (int i = 0; i < 4; i++)
                            {

                                Console.WriteLine("O que deseja alterar:\n" +
                                                 "(1). Nome Visivel\n" +
                                                 "(2). Hobby\n" +
                                                 "(0). Sair\n" +
                                                 "Opcao: ");
                                opcaoSelecionada2 = int.Parse(Console.ReadLine());
                                if (opcaoSelecionada2 == 0)
                                    break;
                                switch (opcaoSelecionada2)
                                {
                                    case 1:
                                        Console.WriteLine("Digite o novo nome: ");
                                        nomeAlterado = Console.ReadLine();
                                        Casa.AlterarDados(nome, nomeAlterado, 1);
                                        break;

                                    case 2:
                                        Console.WriteLine("Digite o novo Hobby: ");
                                        hobby = Console.ReadLine();
                                        Casa.AlterarDados(nome, hobby, 2);
                                        break;
                                }

                            }
                        }
                        else
                            Console.WriteLine("\nNome ou senha invalida!");
                        break;

                    case 4:
                        Casa.RealizarSorteio();
                        break;
                    case 5:
                        Casa.PrintarLista();
                        break;

                    case 6:
                        Console.WriteLine("Digite seu nome: ");
                        nome = Console.ReadLine();

                        if (Casa.ConcluirTarefa(nome) == true)
                            Console.WriteLine("Concluido");
                        else
                            Console.WriteLine("Nome invalido");

                        break;

                    case 7:
                        Casa.PrintarFamilia();
                        break;
                    case 0:
                        return;
                }
            } while (true);
            */
        }

        /*private static void InstaciarTeste()
        {
            Casa.adicionarPessoa(new Filhos("Joao", 12, "321", "correr"));
            Casa.adicionarPessoa(new Filhos("Maria", 10, "654", "jogar"));
            Casa.adicionarPessoa(new Responsavel("Danielle", 39, "456", "Passear"));
            Casa.adicionarPessoa(new Responsavel("Vinicius", 37, "123", "Jogar Futebol"));

            Casa.adicionarTarefa(new Tarefa("Banheiro", 1));
            Casa.adicionarTarefa(new Tarefa("Cozinha", 2));
            Casa.adicionarTarefa(new Tarefa("Quartos", 3));
            Casa.adicionarTarefa(new Tarefa("Passar pano", 4));
        }
        
        public static string CadastrarTarefa()
        {
            string descricao;

            Console.WriteLine("Digite a descricao da tarefa: ");
            descricao = Console.ReadLine();

            return descricao;
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
        }*/
        public static bool Comparar(Object o1, Object o2)
        {
            return o1 == o2;
        }
    }
}

