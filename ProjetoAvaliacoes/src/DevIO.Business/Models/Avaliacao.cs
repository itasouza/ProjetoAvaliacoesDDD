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


        public int PedidoDetalheId { get; set; }
        public virtual PedidoDetalhe PedidoDetalhe { get; set; }
    }
}
