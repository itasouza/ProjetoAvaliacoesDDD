using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class UsuarioViewModel : EntityViewModel
    {
        [DisplayName("Nome do Usuário")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]
        public string NomeUsuario { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} caracteres e {1}", MinimumLength = 2)]
        public string Email { get; set; }

        [DisplayName("Data Cadastro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [ScaffoldColumn(false)]
        public DateTime? DataCadastro { get; set; }

        public ICollection<AvaliacaoViewModel> Avaliacao { get; set; }
    }
}
