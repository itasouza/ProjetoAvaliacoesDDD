namespace DevIO.App.ViewModels
{
    public class CidadeViewModel : EntityViewModel
    {
        public string Nome { get; set; }

        public int EstadoId { get; set; }
        public EstadoViewModel Estado { get; set; }
    }
}
