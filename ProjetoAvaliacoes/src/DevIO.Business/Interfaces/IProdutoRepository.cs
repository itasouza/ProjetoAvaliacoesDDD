﻿using DevIO.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    { 
        Task<Produto> ObterProdutoEspecifico(int id);
        
    }
}
