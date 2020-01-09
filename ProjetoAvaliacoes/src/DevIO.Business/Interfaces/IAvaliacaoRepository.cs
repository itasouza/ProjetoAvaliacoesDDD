using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IAvaliacaoRepository : IRepository<Avaliacao>
    {
        Task<IEnumerable<Avaliacao>> ObterAvaliacoesProdutoUsuario();
        Task<Avaliacao> ObterAvaliacoesProdutoUsuarioEspecifico(int id);
    

    }
}
