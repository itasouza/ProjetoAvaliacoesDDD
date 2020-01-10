using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class ProdutoViewModel : EntityViewModel
    {
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal? ValorProduto { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public string ProdutoPromocao { get; set; }


        public ICollection<ImagemProdutoViewModel> ImagemProduto { get; set; }
        public ICollection<PedidoDetalheViewModel> PedidoDetalhe { get; set; }
    }
}
