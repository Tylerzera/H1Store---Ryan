using AutoMapper;
using GestaoDeProduto.Domain.Etities;
using GestaoDeProduto.Domain.Interfaces;
using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        #region Construtores
        private readonly IProdutoRepository _produtoRepository;
        private IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        #endregion

        #region Funções
        public void Adicionar(NovoProdutoViewModel novoProdutoViewModel)
        {
            var novoProduto = _mapper.Map<Produto>(novoProdutoViewModel);
            _produtoRepository.Adicionar(novoProduto);
        }

        public bool Atualizar(NovoProdutoViewModel novoprodutoViewModel)
        {
            var produto = _mapper.Map<Produto>(novoprodutoViewModel);
            bool atualizadoComSucesso = _produtoRepository.Atualizar(produto);

            if (atualizadoComSucesso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Deletar(int id)
        {
            bool excluidoComSucesso = _produtoRepository.Deletar(id);

            if (excluidoComSucesso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Task<IEnumerable<ProdutoViewModel>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoViewModel> ObterPorId(int id)
        {
            var produto = await _produtoRepository.ObterPorId(id);
            return _mapper.Map<ProdutoViewModel>(produto);
        }


        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {
            var produtos = await _produtoRepository.ObterTodos();
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(produtos);
        }
        #endregion
    }
}
