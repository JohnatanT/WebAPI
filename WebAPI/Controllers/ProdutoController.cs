﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProdutoController : ApiController
    {
        Produto[] produtos = new Produto[]
        {
            new Produto() { Codigo = 1, Nome = "Nokia Lumia", Categoria = "Celulares", Valor = 699.99m},
            new Produto() { Codigo = 2, Nome = "Samsung Galaxy", Categoria = "Celulares", Valor = 899.99m},
            new Produto() { Codigo = 3, Nome = "Teclado", Categoria = "Informatica", Valor = 120.99m},
            new Produto() { Codigo = 4, Nome = "Mouse", Categoria = "Informatica", Valor = 68.99m},
            new Produto() { Codigo = 5, Nome = "Pelicula de Vidro", Categoria = "Acessorios", Valor = 19.99m},
        };

        [HttpGet]
        public IEnumerable<Produto> ListarTodos()
        {
            return produtos;
        }

        [HttpGet]
        public IHttpActionResult Obter(int codigo)
        {
            var produto = produtos.FirstOrDefault(p => p.Codigo == codigo);
            if(produto == null)
            {
                return NotFound();
            }
            else
            {
                //return Ok(produto);
                return Json<Produto>(produto);
            }
        }

        [HttpGet]
        public IEnumerable<Produto> ListarPorCategoria(string categoria)
        {
            return produtos.Where(p => string.Equals(p.Categoria, categoria, StringComparison.OrdinalIgnoreCase));
        }


        public void Post([FromBody] Produto produto)
        {
            //Realiza Cadastro do Produto

        }

        public void Put([FromBody] Produto produto)
        {
            //Realiza Update do Produto

        }

        public void Delete([FromBody] int codigo)
        {
            //Realiza exclusão de um produto com base no código

        }

    }
}
