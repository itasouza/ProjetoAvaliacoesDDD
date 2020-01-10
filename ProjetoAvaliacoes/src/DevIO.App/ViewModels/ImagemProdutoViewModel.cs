
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class ImagemProdutoViewModel 
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome da Imagem")]
        public string FotoProduto { get; set; }

        [DisplayName("Selecione um produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }


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
