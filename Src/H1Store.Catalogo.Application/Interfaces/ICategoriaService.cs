using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.Interface
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaViewModel>> ObterTodos();
        Task<CategoriaViewModel> ObterPorId(int id);
        Task<IEnumerable<CategoriaViewModel>> ObterPorCategoria(int codigo);
        void Adicionar(NovaCategoriaViewModel produto);
        bool Atualizar(NovaCategoriaViewModel produto);
        bool Deletar(int id);
    }
}
