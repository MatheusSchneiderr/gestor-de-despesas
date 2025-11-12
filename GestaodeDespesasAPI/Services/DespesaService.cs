using System;
using System.Collections.Generic;
using GestaodeDespesasAPI.Data.Repositories;
using GestaodeDespesasAPI.Models;

namespace GestaodeDespesasAPI.Services
{
    public class DespesaService : IDespesaService
    {
        private IDespesasRepository _repo;

        public DespesaService()
        {
            _repo = new DespesaRepository();
        }
        
        public IEnumerable<Despesa> GetAll()
        {
            return _repo.GetAll();
        }

        public Despesa GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Despesa despesa)
        {
            _repo.Add(despesa);
        }

        public void Update(Despesa despesa)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}