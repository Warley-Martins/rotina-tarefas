using Curso3_Familia;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rotina_Tarefas_Teste
{
    public class RecebePessoaTest
    {
        [Theory]
        [InlineData(15, "Fulano Ciclano Beltrano")]
        public void LancaNullReferenceExceptionFilhoSemResponsavel(int idade, string nome)
        {
            //Arrange
            Filhos filho;
            //Assert
            Assert.Throws<System.NullReferenceException>(
                            //Act
                            () => filho = new Filhos(nome, idade, null)
                        );
        }
        [Theory]
        [InlineData(-1, "Fulano Ciclano Beltrano")]
        public void LancaArgumentNullExceptionFilhoComIdadeInvalida(int idade, string nome)
        {
            //Arrange
            var responsavel = new Responsavel("Resp", 34);
            Filhos filho;
            //Assert
            Assert.Throws<ArgumentException>(
                //Act
                () => filho = new Filhos(nome, idade, responsavel)
                );
        }
        [Theory]
        [InlineData(-1, "Fulano Ciclano Beltrano")]
        [InlineData(0, "Fulano Ciclano Beltrano")]
        [InlineData(14, "Fulano Ciclano Beltrano")]
        public void LancaArgumentNullExceptionResponsavelComIdadeInvalida(int idade, string nome)
        {
            //Arrange
            Responsavel pai;
            //Assert
            Assert.Throws<ArgumentException>(
                //Act
                () => pai = new Responsavel(nome, idade)
                );
        }
        [Fact]
        public void LancaNullReferenceExceptionInstanciarCasaSemResponsavel()
        {
            //Arranje
            Casa casa;
            //Assert
            Assert.Throws<NullReferenceException>(
                //Act
                () => casa = new Casa(null)
                );
        }
        [Theory]
        [InlineData("Fulano", -1)]
        public void LancaNullReferenceExceptionAdicionarPessoaInvalidaNaCasa(string nome, int idade)
        {
            //Arranje
            var responsavel = new Responsavel("Fulano", 30);
            Casa casa = new Casa(responsavel);
            //Assert
            Assert.Throws<ArgumentException>(
                //Act
                () => casa.adicionarPessoa(new Filhos(nome, idade, responsavel))
            );
        }
        [Theory]
        [InlineData("Fulano", 25, "Filho", 12)]
        public void AdicionarResponsavelCasa(string nomeResp, int idadeResp, string nomeFilho, int idadeFilho)
        {
            //Arranje
            var responsavel = new Responsavel(nomeResp, idadeResp);
            Casa casa = new Casa(responsavel);
            var esperado = true;

            //Act
            var filho = new Filhos(nomeFilho, idadeFilho, responsavel);
            var obtido = casa.adicionarPessoa(filho);
            //Assert
            Assert.Equal(esperado, obtido);
        }
    }
}
