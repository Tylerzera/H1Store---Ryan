using AutoMapper;
using GestaoDeProduto.Domain.Etities;
using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.AutoMapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Produto, ProdutoViewModel>();

            CreateMap<Produto, NovoProdutoViewModel>();

            CreateMap<Fornecedor, FornecedorViewModel>();

            CreateMap<Fornecedor, NovoFornecedorViewModel>();

            CreateMap<Categoria, CategoriaViewModel>();

            CreateMap<Categoria, NovaCategoriaViewModel>();
        }
    }
}
