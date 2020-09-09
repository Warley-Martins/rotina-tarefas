using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Curso3_Familia
{
    /// <summary>
    /// Classe Filho
    /// </summary>
    public class Filhos : Pessoa
    {
        /// <summary>
        /// Responsaveis do filho
        /// </summary>
        public List<Responsavel> Responsaveis { get;}
        /// <summary>
        /// Construtor de filho
        /// </summary>        
        /// <param name="nome">Nome da Pessoa</param>
        /// <param name="idade">Idade da Pessoa</param>
        /// <param name="responsaveis">Responsaveis pelo filho</param>
        /// <exception cref="ArgumentException">O parametro: <paramref name="idade"/>, não pode ser nula ou negativa!</exception>
        /// <exception cref="ArgumentException">O parametro: <paramref name="nome"/>, não pode ser nulo ou vazio!</exception>
        /// <exception cref="ArgumentException">O parametro: <paramref name="responsaveis"/>, não possui refencia definida!</exception>
        public Filhos(string nome, int idade, params Responsavel[] responsaveis)
            : base(nome)
        {
            if (idade < 0)
            {
                throw new ArgumentException("A Idade não pode ser negativa!");
            }
            Console.WriteLine(responsaveis);
            if (responsaveis[0] == null || responsaveis == null)
            {
                throw new NullReferenceException("O filho não pode ser criado sem um, ou mais, responsaveis! ");
            }
            this.Responsaveis = new List<Responsavel>();
            foreach (var item in responsaveis)
            {
                this.Responsaveis.Add(item);
            }
        }
        /// <summary>
        /// Realiza a tarefa destinada
        /// </summary>
        public override void RealizarTarefa()
        {
            this.Tarefa.Concluida = true;
        }
    }
}
