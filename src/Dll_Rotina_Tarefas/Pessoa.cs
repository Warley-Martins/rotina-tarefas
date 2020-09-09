using System;
using System.Collections.Generic;
using System.Text;

namespace Curso3_Familia
{
    /// <summary>
    /// Classe que representa uma pessoa
    /// </summary>
    public abstract class Pessoa
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome">Nome da Pessoa</param>
        /// <exception cref="ArgumentException">O parametro: <paramref name="nome"/>, não pode ser nulo ou vazio!</exception>
        public Pessoa(string nome)
        {
            if (String.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome não pode ser nulo ou vazio!");
            }
            this.Nome = nome;
            Tarefa = new Tarefa();
        }
        /// <summary>
        /// Nome da pessoa
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Idade da pessoa
        /// </summary>
        public int Idade { get; set; }
        /// <summary>
        /// Tarefa da pessoa
        /// </summary>
        public Tarefa Tarefa = new Tarefa();
        public abstract void RealizarTarefa();
    }
}
