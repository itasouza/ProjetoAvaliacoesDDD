using System.Collections.Generic;

namespace DevIO.App.ViewModels
{
    public class EstadoViewModel : EntityViewModel
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public ICollection<CidadeViewModel> Cidade { get; set; }
    }
}
