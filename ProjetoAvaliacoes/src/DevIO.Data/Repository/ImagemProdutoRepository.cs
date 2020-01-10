using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;

namespace DevIO.Data.Repository
{
    public class ImagemProdutoRepository : Repository<ImagemProduto>, IImagemProdutoRepository
    {
        public ImagemProdutoRepository(MeuDbContext context) : base(context) { }
    }
}
