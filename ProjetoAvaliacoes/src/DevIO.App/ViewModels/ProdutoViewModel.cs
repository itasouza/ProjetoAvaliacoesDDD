using DevIO.App.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class ProdutoViewModel : EntityViewModel
    {

        [DisplayName("Nome do Produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]
        public string NomeProduto { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]
        public string DescricaoProduto { get; set; }

        [Moeda]
        [DisplayName("Valor do produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal? ValorProduto { get; set; }

        [DisplayName("Ativo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Ativo { get; set; }

        [DisplayName("Data de Fabricação")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //  [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? DataFabricacao { get; set; }

        [DisplayName("Data de Validade")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? DataValidade { get; set; }

        [DisplayName("Imagem do Produto")]
        [ScaffoldColumn(false)]
        public string FotoProduto { get; set; }

        [DisplayName("Produto em Promoção")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ProdutoPromocao { get; set; }

        public ICollection<AvaliacaoViewModel> Avaliacao { get; set; }
    }
}
