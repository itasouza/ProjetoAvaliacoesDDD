using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;

namespace DevIO.Data.Repository
{
    public class PedidoDetalheRepository : Repository<PedidoDetalhe>, IPedidoDetalheRepository
    {
        public PedidoDetalheRepository(MeuDbContext context) : base(context) { }
    }
}
