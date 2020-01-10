using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class EstadoViewModel 
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome do Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Sigla do Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa ter 2 caracteres", MinimumLength = 2)]
        public string Sigla { get; set; }

        public ICollection<CidadeViewModel> Cidade { get; set; }


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
