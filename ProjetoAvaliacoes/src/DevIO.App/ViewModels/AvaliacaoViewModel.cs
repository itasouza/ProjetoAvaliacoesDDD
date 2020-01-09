using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class AvaliacaoViewModel : EntityViewModel
    {
        [DisplayName("Título da Avaliação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]
        public string Titulo { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]
        public string Descricao { get; set; }


        [DisplayName("Quantidade de estrelas")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int? QuantidadeEstrela { get; set; }


        [DisplayName("Data Cadastro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [ScaffoldColumn(false)]
        public DateTime? DataCadastro { get; set; }

        [DisplayName("Avaliação foi útil")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AvaliacaoUtil { get; set; }

        [DisplayName("Nome do Produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }

        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int UsuarioId { get; set; }
        public UsuarioViewModel Usuario { get; set; }
    }
}
