using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Etities
{
    //entities - entidades
    public class Produto
    {

        #region Construtores
        // primeiro construtor que excluir
        //public Produto(int codigo, string nome, int qtdeEstoque, DateTime dataCadastro, bool ativo)
        //{
        //    //this.Codigo = codigo;
        //    //this.Nome = nome;
        //    //this.QtdeEstoque = qtdeEstoque;
        //    //this.DataCadastro = dataCadastro;
        //    //this.Ativo = ativo;
        //}

        //segundo construtor que excluí
        //public Produto(int codigo, string nome, int qtdeEstoque, DateTime dataCadastro, bool ativo)
        //{
        //    Codigo = codigo;
        //    Nome = nome;
        //    QtdeEstoque = qtdeEstoque;
        //    DataCadastro = dataCadastro;
        //    Ativo = ativo;
        //}

        public Produto(int codigo, string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            Estoque = estoque;
        }

        #endregion



        #region Propriedades

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public int Estoque { get; private set; }

        #endregion

        #region Funções

        public void Ativar()
        {
            Ativo = true;
        }

        public void Desativar()
        {
            Ativo = false;
        }

        public void AlterarDescricao(string novaDescricao)
        {
            Descricao = novaDescricao;
        }

        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
        }

        public void AdicionarEstoque(int quantidade)
        {
            Estoque += quantidade;
        }

        public void BaixarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            if (!PossuiEstoque(quantidade)) throw new Exception("Estoque insuficiente");
            Estoque -= quantidade;
        }
        public bool PossuiEstoque(int quantidade) => Estoque >= quantidade;


        #endregion
    }
}
