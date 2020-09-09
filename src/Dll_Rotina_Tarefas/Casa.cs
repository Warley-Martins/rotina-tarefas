using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Curso3_Familia
{
    /// <summary>
    /// Casa com pessoas e tarefas
    /// </summary>
    public class Casa
    {

        private List<Tarefa> ListaTarefas = new List<Tarefa>();
        private List<Pessoa> Pessoas = new List<Pessoa>();

        public Casa(params Pessoa[] pessoas)
        {
            List<Responsavel> responsaveis = new List<Responsavel>();
            foreach (var item in pessoas)
            {
                var respo = item as Responsavel;
                if (respo != null)
                {
                    responsaveis.Add(respo);
                }
            }
            if (responsaveis[0] == null)
            {
                throw new NullReferenceException("A pessoa responsavel pela casa não pode ser nula");
            }
            foreach (var item in responsaveis)
            {
                this.Pessoas.Add(item);
            }
        }
        /// <summary>
        /// Adiciona uma pessoa a casa
        /// </summary>
        /// <param name="pessoa">Pessoa a ser adicionada</param>
        /// <exception cref="NullReferenceException">O parametro: <paramref name="pessoa"/>, não possui refência adionada!</exception>
        public bool adicionarPessoa(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                throw new NullReferenceException("Referencia não adicionada para pessoa");
            }
            Pessoas.Add(pessoa);
            return true;
        }
        /// <summary>
        /// Adiciona uma tarefa a casa
        /// </summary>
        /// <param name="tarefa">Tarefa a ser adicionada</param>
        /// <exception cref="NullReferenceException">O parametro: <paramref name="tarefa"/>, não possui refência adionada!</exception>
        public bool adicionarTarefa(Tarefa tarefa)
        {
            if (tarefa == null)
            {
                throw new NullReferenceException("Referencia não adicionada para tarefa");
            }
            ListaTarefas.Add(tarefa);
            return true;
        }
        /// <summary>
        /// Realiza o sorteio das tarefas
        /// </summary>
        public  void RealizarSorteio()
        {
            Random random = new Random();
            int numGerado;
            int tamanhoLista = ListaTarefas.Count();
            foreach (var pessoa in this.Pessoas)
            {
                do
                {
                    numGerado = random.Next(1, (tamanhoLista+1));
                    Console.WriteLine(numGerado);
                } while (Conferir(numGerado) == false);

                foreach (var tarefa in this.ListaTarefas)
                    if (tarefa.Valor == numGerado)
                        pessoa.Tarefa = tarefa; 
                
            }

        }
        /// <summary>
        /// Printa as tarefas da casa
        /// </summary>
        public void PrintarLista()
        {

            foreach(var tarefas in this.ListaTarefas)
            {
                tarefas.ToString().Replace(',',' ');
            }

        }
        /// <summary>
        /// Printa o Resultado do sorteio
        /// </summary>
        public void PrintarFamilia()
        {
            foreach (var pessoa in this.Pessoas)
            {
                pessoa.ToString().Replace(',','\n');
            }
        }
        private bool Conferir(int num)
        {
            foreach(var i in this.Pessoas)
                if (i.Tarefa.Valor == num)
                    return false;
            return true;
        }


    }
}
