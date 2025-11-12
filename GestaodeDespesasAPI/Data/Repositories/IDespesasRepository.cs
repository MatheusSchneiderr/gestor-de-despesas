using System;
using System.Collections.Generic;
using GestaodeDespesasAPI.Models;

namespace GestaodeDespesasAPI.Data.Repositories
{
    public interface IDespesasRepository
    {
        IEnumerable<Despesa> GetAll();
        Despesa GetById(Guid id);
        void Add(Despesa despesa);
        void Update(Despesa despesa);
        void Delete(Guid id);
    }
}