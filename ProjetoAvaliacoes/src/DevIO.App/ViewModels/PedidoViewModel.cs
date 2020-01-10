using DevIO.App.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class PedidoViewModel 
    {
        [Key]
        public int Id { get; set; }

        [Moeda]
        [DisplayName("Valor Total")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal? ValorTotal { get; set; }

        [DisplayName("Selecione o Cliente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int ClienteId { get; set; }
        public ClienteViewModel Cliente { get; set; }


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
