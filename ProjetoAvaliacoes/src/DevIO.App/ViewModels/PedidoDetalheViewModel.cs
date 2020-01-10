using System.Collections.Generic;

namespace DevIO.App.ViewModels
{
    public class PedidoDetalheViewModel : EntityViewModel
    {
        public int? Quantidade { get; set; }
        public decimal? ValorProduto { get; set; }


        public int PedidoId { get; set; }
        public PedidoViewModel Pedido { get; set; }

        public int ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }

        public ICollection<AvaliacaoViewModel> Avaliacao { get; set; }
    }
}
