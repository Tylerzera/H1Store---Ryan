using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.Interface
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoViewModel>> ObterTodos();
        Task<ProdutoViewModel> ObterPorId(int id);
        Task<IEnumerable<ProdutoViewModel>> ObterPorCategoria(int codigo);

        void Adicionar(NovoProdutoViewModel novoProdutoViewModel);
        bool Atualizar(NovoProdutoViewModel novoProdutoViewModel);
        bool Deletar(int id);
    }
}
