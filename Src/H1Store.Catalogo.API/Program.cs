
using GestaoDeProduto.Data.Repositories;
using GestaoDeProduto.Domain.Interfaces;
using LojaH1.Catalogo.Application.AutoMapper;
using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAutoMapper(typeof(ApplicationToDomain), typeof(DomainToApplication));



builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IFornecedorService, FornecedorService>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//comentei daqui pra baixo

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

////configurando a injeção de dependencia
//builder.Services.AddScoped<IProdutoService, ProdutoService>();
//builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

//builder.Services.AddScoped<ICategoriaService, CategoriaService>();
//IServiceCollection serviceCollection = builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();

//builder.Services.AddScoped<IFornecedorService, FornecedorService>();
//builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
