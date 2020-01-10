using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
   public class Estado : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public  ICollection<Cidade> Cidade { get; set; }

    }
}
