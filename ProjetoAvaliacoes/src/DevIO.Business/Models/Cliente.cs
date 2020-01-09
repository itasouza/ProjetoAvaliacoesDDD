using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Cliente : Entity
    {

        public string NomeCliente { get; set; }
        public string Email { get; set; }

        public int EstadoID { get; set; }
        public Estado Estado { get; set; }

        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }

    }
}
