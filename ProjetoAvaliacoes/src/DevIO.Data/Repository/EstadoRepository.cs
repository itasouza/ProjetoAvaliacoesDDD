using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Repository
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {
        public EstadoRepository(MeuDbContext context) : base(context) { }
    }
}
