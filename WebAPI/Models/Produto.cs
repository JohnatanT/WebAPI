using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Produto
    {
        //Atributos
        private int codigo;
        private string nome;
        private string categoria;
        private decimal valor;

        //Gets e Sets
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public decimal Valor { get { return valor; } set { valor = value; } }

    }
}