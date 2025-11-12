using System;
using System.Collections.Generic;
using GestaodeDespesasAPI.Models;
using MySql.Data.MySqlClient;

namespace GestaodeDespesasAPI.Data.Repositories
{
    public class DespesaRepository : IDespesasRepository
    {
        public IEnumerable<Despesa> GetAll()
        {
            var despesas = new List<Despesa>();
            
            using (var conn = new AppDbContext().CreateConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM Despesa;", conn);
                var reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    var despesa = new Despesa
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Descricao = reader["descricao"].ToString(),
                        Valor = Convert.ToDecimal(reader["valor"])
                    };
                    despesas.Add(despesa);
                }
            }
            
            return despesas;
        }

        public Despesa GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Despesa despesa)
        {
            using (var conn = new AppDbContext().CreateConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO Despesa (descricao, valor) VALUES(@v1,@v2);", conn);
                cmd.Parameters.AddWithValue("@v1", despesa.Descricao);
                cmd.Parameters.AddWithValue("@v2", despesa.Valor);
                cmd.ExecuteNonQuery();
            }
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