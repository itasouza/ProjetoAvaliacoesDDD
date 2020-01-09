using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }

        public async Task<Produto> ObterProdutoEspecifico(int produtoId)
        {
            return await Db.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == produtoId);
        }


        public async Task<IEnumerable<Produto>> ObterProdutosComAvaliacao()
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Avaliacao)
                .OrderBy(p => p.NomeProduto).ToListAsync();
        }
    }
}
