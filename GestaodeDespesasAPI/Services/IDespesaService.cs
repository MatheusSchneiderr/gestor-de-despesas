using System;
using System.Collections.Generic;
using GestaodeDespesasAPI.Models;

namespace GestaodeDespesasAPI.Services
{
    public interface IDespesaService
    {
        IEnumerable<Despesa> GetAll();
        Despesa GetById(Guid id);
        void Add(Despesa despesa);
        void Update(Despesa despesa);
        void Delete(Guid id);
    }
}