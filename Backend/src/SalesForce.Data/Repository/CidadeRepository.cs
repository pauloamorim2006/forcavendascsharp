﻿using ERP.Business.Intefaces;
using ERP.Business.Models;
using ERP.Data.Context;
using SalesForce.Data.Cache;
using System;
using System.Linq;

namespace ERP.Data.Repository
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(SalesForceDbContext context, ICache cache) : base(context, cache) { }

        public bool JaExiste(Guid id, int codigoIbge)
        {
            return Buscar(f => f.CodigoIbge == codigoIbge && f.Id != id).Result.Any();
        }

        public bool Encontrou(Guid id)
        {
            return Buscar(f => f.Id == id).Result.Any();
        }
    }
}
