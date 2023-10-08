using GestaoDeProduto.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Interfaces
//interfaces - onde colocamos as ações que a entidade faz (entities)
{ //aqui vamos implementar o que fazer e não como fazer  - exemplos abaixo do que eu posso fazer com um produto -> adc, atualizar
  //ou seja aqui é só a assinatura do que o método faz e não executa
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(int id);
        Task<IEnumerable<Produto>> ObterPorCategoria(int codigo);

        void Adicionar(Produto novoproduto);
        bool Atualizar(Produto produto);
        bool Deletar(int id);


    }
}
