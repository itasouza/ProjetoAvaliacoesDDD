﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DevIO.Business.Models
{
    public partial class ImagemProduto
    {
        public int ImagemId { get; set; }
        public int ProdutoId { get; set; }
        public string FotoProduto { get; set; }

        public virtual Produto Produto { get; set; }
    }
}