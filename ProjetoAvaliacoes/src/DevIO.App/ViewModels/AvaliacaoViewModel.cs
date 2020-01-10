using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class AvaliacaoViewModel : EntityViewModel
    {

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int? QuantidadeEstrela { get; set; }
        public string AvaliacaoUtil { get; set; }

        public int PedidoDetalheId { get; set; }
        public virtual PedidoDetalheViewModel PedidoDetalhe { get; set; }


    }
}
