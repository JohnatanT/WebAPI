using System;
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

        public IEnumerable<Produto> ListarTodos()
        {
            return produtos;
        }

        public IHttpActionResult Obter(int codigo)
        {
            var produto = produtos.FirstOrDefault(p => p.Codigo == codigo);
            if(produto == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(produto);
            }
        }

        public IEnumerable<Produto> ListarPorCategoria(string categoria)
        {
            return produtos.Where(p => string.Equals(p.Categoria, categoria, StringComparison.OrdinalIgnoreCase));
        }
    }
}
