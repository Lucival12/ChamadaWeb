using System;
using System.Collections.Generic;
using System.Text;

namespace ChamadaWeb.Model
{
    class Service
    {

        public List<Aprovacao> GetAprovacoes()
        {
            List<Aprovacao> aprovacoes = new List<Aprovacao>();

            Aprovacao aprovacao = new Aprovacao
            {
                itens = new List<ItemAprovacao>(),
                numeroDocumento = "000001",
                valorTotal = "19.600,00",
                dataEmissao = "23/05/2018",
                dataLiberacao = "02/04/2019",
                fornecedor = "SHULUMBERGER SERVICOS DE PETROLEO"
            };

            aprovacao.itens.Add(new ItemAprovacao
            {
                descricao = "SERVICO DE CANHONEIO",
                numeroProduto = "999990004",
                precoUnitatio = "4.200,00",
                quantidade = "2",
                valorTotal = "8.400,00"

            });
            aprovacao.itens.Add(new ItemAprovacao
            {
                descricao = "SERVICO DE CONSULTORIA",
                numeroProduto = "999990010",
                precoUnitatio = "350,00",
                quantidade = "32,00",
                valorTotal = "11.200,00"

            });


            Aprovacao aprovacao2 = new Aprovacao
            {
                itens = new List<ItemAprovacao>(),
                numeroDocumento = "000007",
                valorTotal = "8.400,00",
                dataEmissao = "05/09/2018",
                dataLiberacao = "06/04/2019",
                fornecedor = "PETROBRAS"
            };

            aprovacao2.itens.Add(new ItemAprovacao
            {
                descricao = "SERVICO DE AAA",
                numeroProduto = "999990004",
                precoUnitatio = "4.200,00",
                quantidade = "2",
                valorTotal = "8.400,00"

            });
            aprovacao2.itens.Add(new ItemAprovacao
            {
                descricao = "SERVICO DE 888888",
                numeroProduto = "999990010",
                precoUnitatio = "350,00",
                quantidade = "32,00",
                valorTotal = "11.200,00"

            });


            aprovacoes.Add(aprovacao);
            aprovacoes.Add(aprovacao2);


            return aprovacoes;
        }
        public bool Login(string login, string senha)
        {
            if (login == "ti" && senha == "123")
            {
                UsuarioLogado.Instance.signIn(new Usuario { user = login, senha = senha });
                return true;
            }

            return false;
        }
    }
}
