using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Avaliacao : Entity
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int? QuantidadeEstrela { get; set; }
        public string AvaliacaoUtil { get; set; }

        public int ProdutoId { get; set; }
        public  Produto Produto { get; set; }

        public int UsuarioId { get; set; }
        public  Usuario Usuario { get; set; }
    }
}
