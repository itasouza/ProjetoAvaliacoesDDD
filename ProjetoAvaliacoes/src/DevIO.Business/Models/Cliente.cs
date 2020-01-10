using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Cliente : Entity
    {


        public string NomeCliente { get; set; }
        public string Email { get; set; }


        public int? EstadoId { get; set; }
        public int? CidadeId { get; set; }

        public  ICollection<Pedido> Pedido { get; set; }

    }
}
