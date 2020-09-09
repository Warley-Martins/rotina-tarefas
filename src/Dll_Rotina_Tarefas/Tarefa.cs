using System;
using System.Collections.Generic;
using System.Text;

namespace Curso3_Familia
{
    /// <summary>
    /// Tarefa da casa
    /// </summary>
    public class Tarefa
    {
        /// <summary>
        /// Construtor default
        /// 
        /// </summary>
        public Tarefa()
        {

        }
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="descricao">Descrição da tarefa</param>
        /// <exception cref="ArgumentException">O parametro: <paramref name="descricao"/>, não pode ser nulo ou vazio!</exception>
        public Tarefa(string descricao)
        {
            if (String.IsNullOrEmpty(descricao))
            {
                throw new ArgumentNullException("O nome não pode ser nulo ou vazio!");
            }
            this.Descricao = descricao;
            Quantidade++;
            this.Valor = Quantidade;
        }
        private static int Quantidade;
        /// <summary>
        /// Descrição da tarefa
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Estado logico se a tarefa foi concluida ou nao
        /// </summary>
        public bool Concluida { get; set; }
        /// <summary>
        /// numero da tarefa
        /// </summary>
        public int Valor { get; set; }
        /// <summary>
        /// Retorna uma string com as informações
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Valor},{Descricao}";
        }
    }
}

