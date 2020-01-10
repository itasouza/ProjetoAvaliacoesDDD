using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Produto : Entity
    {

        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal? ValorProduto { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public string ProdutoPromocao { get; set; }


        public  ICollection<ImagemProduto> ImagemProduto { get; set; }
        public  ICollection<PedidoDetalhe> PedidoDetalhe { get; set; }
    }
}
