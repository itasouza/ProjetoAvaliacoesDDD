using DevIO.App.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class ProdutoViewModel 
    {
        [Key]
        public int Id { get; set; }

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

        [DisplayName("Data de Fabricação")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime? DataFabricacao { get; set; }

        [DisplayName("Data de Validade")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime? DataValidade { get; set; }

        [DisplayName("Produto em Promoção")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1, ErrorMessage = "O campo {0} precisa ser (S/N)", MinimumLength = 1)]
        public string ProdutoPromocao { get; set; }


        public ICollection<ImagemProdutoViewModel> ImagemProduto { get; set; }
        public ICollection<PedidoDetalheViewModel> PedidoDetalhe { get; set; }

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
