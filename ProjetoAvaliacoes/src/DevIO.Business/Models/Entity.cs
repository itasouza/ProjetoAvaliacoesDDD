using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Ativo { get; set; }


    }
}
