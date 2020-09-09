using Curso3_Familia;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rotina_Tarefas_Teste
{
    public class AdicionaTarefaTest
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void LancaArgumentExceptionAoReceberTarefaInvalida(string descricao)
        {
            //Arranje
            Tarefa tarefa;
            //Asset
            Assert.Throws<System.ArgumentException>(
                //act
                () => tarefa = new Tarefa(descricao)
                );
        }
    }
}
