using GestaoDeProduto.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        //public void Adicionar(Categoria novaCategoria);
        //public Categoria BuscarPorId(int codigo);

        //public IEnumerable<Categoria> BuscarTodos();
        //public IEnumerable<Categoria> BuscarTodosAtivos();
        //public IEnumerable<Categoria> BuscarTodosInativos();

        Task<IEnumerable<Categoria>> ObterTodos();
        Task<Categoria> ObterPorId(int id);
        Task<IEnumerable<Categoria>> ObterPorCategoria(int codigo);
        void Adicionar(Categoria categoria);
        bool Atualizar(Categoria categoria);
        bool Deletar(int id);
    }
}
