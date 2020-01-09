using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Cidade : Entity
    {
        public int EstadoID { get; set; }
        public string Nome { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
    }
}
