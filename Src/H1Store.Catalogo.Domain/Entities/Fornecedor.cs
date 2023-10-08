using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Etities
{
    public class Fornecedor
    {

        #region Construtores
        //public Fornecedor(int codigo, string razaoSocial, string cnpj, DateTime dataCadastro, bool ativo, string emailContato)
        //{
        //    Codigo = codigo;
        //    razaoSocial = razaoSocial;
        //    cnpj = cnpj;
        //    DataCadastro = dataCadastro;
        //    Ativo = ativo;
        //    emailContato = emailContato;
        //}
        public Fornecedor(int codigo, string razaoSocial, string cnpj, DateTime dataCadastro, bool ativo, string emailContato)
        {
            Codigo = codigo;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            EmailContato = emailContato;
        }



        #endregion

        #region Propriedades

        public int Codigo { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }
        public string EmailContato { get; private set; }

        #endregion

        #region Comportamentos
        public void Ativar()
        {
            Ativo = true;
        }

        public void Desativar()
        {
            Ativo = false;
        }

        public void AlterarRazaoSocial(string novaRazaoSocial)
        {
            RazaoSocial = novaRazaoSocial;
        }

        public void AlterarEmailContato(string novoEmailContato)
        {
            EmailContato = novoEmailContato;
        }


        #endregion

    }
}
