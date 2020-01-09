using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
   public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MeuDbContext context) : base(context) { }

        public async Task<IEnumerable<Usuario>> ObterTodosUsuario()
        {
            return await Db.Usuarios.AsNoTracking().OrderBy(p => p.NomeUsuario).ToListAsync();
        }

        public async Task<Usuario> ObterUsuarioEspecifico(int usuarioId)
        {
            return await Db.Usuarios.AsNoTracking().FirstOrDefaultAsync(p => p.Id == usuarioId);
        }
    }
}
