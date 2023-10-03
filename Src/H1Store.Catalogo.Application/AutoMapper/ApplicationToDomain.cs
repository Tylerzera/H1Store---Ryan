﻿using AutoMapper;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<ProdutoViewModel, Produto>()
			   .ConstructUsing(q => new Produto(q.Codigo,q.Nome,q.Descricao,q.Ativo,q.Valor,q.DataCadastro,q.Imagem,q.QuantidadeEstoque));
			CreateMap<NovoProdutoViewModel, Produto>()
			   .ConstructUsing(q => new Produto(0, q.Nome, q.Descricao, q.Ativo, q.Valor, q.DataCadastro, q.Imagem, q.QuantidadeEstoque));
            CreateMap<CategoriaViewModel, Categoria>()
               .ConstructUsing(w => new Categoria(w.Codigo, w.Descricao));
            CreateMap<NovaCategoriaViewModel, Categoria>()
               .ConstructUsing(w => new Categoria(0, w.Descricao));
            CreateMap<FornecedorViewModel, Fornecedor>()
               .ConstructUsing(y => new Fornecedor(y.Codigo, y.RazaoSocial, y.CNPJ, y.Ativo, y.DataCadastro, y.EmailContato));
            CreateMap<NovoFornecedorViewModel, Fornecedor>()
               .ConstructUsing(y => new Fornecedor(0, y.RazaoSocial, y.CNPJ, y.Ativo, y.DataCadastro, y.EmailContato));
        }
	}
}
