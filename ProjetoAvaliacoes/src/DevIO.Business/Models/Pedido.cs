using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public  class Pedido : Entity
    {

        public decimal? ValorTotal { get; set; }


        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public  ICollection<PedidoDetalhe> PedidoDetalhe { get; set; }
    }
}
