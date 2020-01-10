

namespace DevIO.App.ViewModels
{
    public class ImagemProdutoViewModel : EntityViewModel
    {
        public string FotoProduto { get; set; }

        public int ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }
    }
}
