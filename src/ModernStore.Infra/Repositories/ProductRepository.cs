using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TestFCamara.Domain.Commands.Results;
using TestFCamara.Domain.Entities;
using TestFCamara.Domain.Repositories;
using TestFCamara.Infra.Contexts;
using TestFCamara.Shared;

namespace TestFCamara.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DB_FCAMARADataContext _context;

        public ProductRepository(DB_FCAMARADataContext context)
        {
            _context = context;
        }

        public Product Get(Guid id)
        {
            return _context
                .Products
                .AsNoTracking()
                .FirstOrDefault(x=>x.Id == id);
        }

        public IEnumerable<GetProductListCommandResult> Get()
        {
            var query = "SELECT [Id], [Title], [Price], [Image] FROM [Product]";
            using (var conn = new SqlConnection(Runtime.ConnectionString))
            {
                conn.Open();
                return conn.Query<GetProductListCommandResult>(query);
            }
        }
    }
}
