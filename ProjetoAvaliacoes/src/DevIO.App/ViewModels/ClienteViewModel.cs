using System.Collections.Generic;

namespace DevIO.App.ViewModels
{
    public class ClienteViewModel : EntityViewModel
    {
        public string NomeCliente { get; set; }
        public string Email { get; set; }


        public int? EstadoId { get; set; }
        public int? CidadeId { get; set; }

        public ICollection<PedidoViewModel> Pedido { get; set; }
    }
}
