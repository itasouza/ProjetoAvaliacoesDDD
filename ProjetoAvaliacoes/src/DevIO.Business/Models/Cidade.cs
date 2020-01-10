using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Cidade : Entity
    {
  
        public string Nome { get; set; }


        public int EstadoId { get; set; }
        public  Estado Estado { get; set; }
    }
}
