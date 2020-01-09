using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class AvaliacaoRepository : Repository<Avaliacao>, IAvaliacaoRepository
    {
        public AvaliacaoRepository(MeuDbContext context) : base(context) { }

        public async Task<IEnumerable<Avaliacao>> ObterAvaliacoesProdutoUsuario()
        {
            return await Db.Avaliacoes.AsNoTracking().Include(f => f.Produto).Include(s => s.Usuario)
                .OrderBy(p => p.ProdutoId).ToListAsync();

        }

        public async Task<Avaliacao> ObterAvaliacoesProdutoUsuarioEspecifico(int id)
        {
            return await Db.Avaliacoes.AsNoTracking().Include(f => f.Produto).Include(s => s.Usuario)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
