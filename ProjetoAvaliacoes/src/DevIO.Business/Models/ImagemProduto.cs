using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class ImagemProduto : Entity
    {

        public string FotoProduto { get; set; }

        public int ProdutoId { get; set; }
        public  Produto Produto { get; set; }
    }
}
