using System;
using System.Collections.Generic;
using System.Text;

namespace Curso3_Familia
{
    /// <summary>
    /// Responsavel da casa
    /// </summary>
    public class Responsavel : Pessoa
    {
        
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome">Nome da Pessoa</param>
        /// <param name="idade">Idade da Pessoa</param>
        /// <exception cref="ArgumentException">O parametro: <paramref name="idade"/>, não pode ser nula ou negativa!</exception>
        /// <exception cref="ArgumentException">O parametro: <paramref name="nome"/>, não pode ser nulo ou vazio!</exception>
        public Responsavel(string nome, int idade) 
            : base(nome)
        {
            if(idade < 18)
            {
                throw new ArgumentException("Um responsavel não pode ter menos que 18 anos!");
            }
            this.Idade = idade;
        }

        /// <summary>
        /// Realiza a tarefa destinada
        /// </summary>
        public override void RealizarTarefa()
        {
            this.Tarefa.Concluida = true;
        }
        /// <summary>
        /// Informações
        /// </summary>
        /// <returns>retorna uma string com informações</returns>
        public override string ToString()
        {
            return $"{Nome},{Idade}";
        }
    }
}
