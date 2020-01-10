using System.Collections.Generic;

namespace DevIO.App.ViewModels
{
    public class PedidoViewModel : EntityViewModel
    {
        public decimal? ValorTotal { get; set; }


        public int ClienteId { get; set; }
        public ClienteViewModel Cliente { get; set; }
        public ICollection<PedidoDetalheViewModel> PedidoDetalhe { get; set; }
    }
}
