using DevIO.App.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class PedidoDetalheViewModel 
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Quantidade do produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, 100)]
        public int? Quantidade { get; set; }

        [Moeda]
        [DisplayName("Valor do produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal? ValorProduto { get; set; }

        [DisplayName("Selecione o Pedido")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int PedidoId { get; set; }
        public PedidoViewModel Pedido { get; set; }

        [DisplayName("Selecione o produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }

        public ICollection<AvaliacaoViewModel> Avaliacao { get; set; }

        [DisplayName("Ativo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1, ErrorMessage = "O campo {0} precisa ser (S/N)", MinimumLength = 1)]
        public string Ativo { get; set; }

        [DisplayName("Data Cadastro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataCadastro { get; set; }

        [DisplayName("Data Alteração")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataAlteracao { get; set; }
    }
}
