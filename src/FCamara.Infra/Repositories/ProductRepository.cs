using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using FCamaraProject.Domain.Commands.Results;
using FCamaraProject.Domain.Entities;
using FCamaraProject.Domain.Repositories;
using FCamaraProject.Infra.Contexts;
using FCamaraProject.Shared;

namespace FCamaraProject.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly FCamaraDataContext _context;

        public ProductRepository(FCamaraDataContext context)
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
