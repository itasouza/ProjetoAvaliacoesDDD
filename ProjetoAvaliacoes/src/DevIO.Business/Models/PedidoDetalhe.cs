using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public  class PedidoDetalhe : Entity
    {

        public int? Quantidade { get; set; }
        public decimal? ValorProduto { get; set; }


        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int ProdutoId { get; set; }
        public  Produto Produto { get; set; }

        public  ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
