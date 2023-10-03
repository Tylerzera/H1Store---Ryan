﻿using AutoMapper;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriaViewModel>> ObterTodasCategorias()
        {
            var categorias = await _categoriaRepository.ObterTodos();
            return _mapper.Map<IEnumerable<CategoriaViewModel>>(categorias);
        }

        public async Task<CategoriaViewModel> ObterCategoriaPorCodigo(int codigo)
        {
            var categoria = await _categoriaRepository.ObterPorCodigo(codigo);
            return _mapper.Map<CategoriaViewModel>(categoria);
        }

        public async Task AdicionarCategoria(NovaCategoriaViewModel novaCategoria)
        {
            var categoria = _mapper.Map<Categoria>(novaCategoria);
            await _categoriaRepository.Adicionar(categoria);
        }

        public async Task AtualizarCategoria(CategoriaViewModel categoria)
        {
            var categoriaAtualizada = _mapper.Map<Categoria>(categoria);
            await _categoriaRepository.Atualizar(categoriaAtualizada);
        }

        public async Task RemoverCategoria(int codigo)
        {
            await _categoriaRepository.Remover(codigo);
        }
    }
}
