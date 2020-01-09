using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
   public class Usuario:Entity
    {
        public string NomeUsuario { get; set; }
        public string Email { get; set; }

        public ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
