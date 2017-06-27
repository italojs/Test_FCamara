using System;
using System.Data.Entity;
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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DB_FCAMARADataContext _context;

        public CustomerRepository(DB_FCAMARADataContext context)
        {
            _context = context;
        }

        public Customer Get(Guid id)
        {
            return _context
                .Customers
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == id);
        }

        public Customer GetByUsername(string username)
        {
            return _context
                .Customers
                .Include(x => x.User)
                .AsNoTracking()
                .FirstOrDefault(x => x.User.Username == username);
        }

        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
        }


        public GetCustomerCommandResult Get(string username)
        {
            //return _context
            //    .Customers
            //    .Include(x => x.User)
            //    .AsNoTracking()
            //    .Select(x => new GetCustomerCommandResult
            //    {
            //        Name = x.Name.ToString(),
            //        Document = x.Document.Number,
            //        Active = x.User.Active,
            //        Email = x.Email.Address,
            //        Password = x.User.Password,
            //        Username = x.User.Username
            //    })
            //    .FirstOrDefault(x => x.Username == username);

            var query = "SELECT * FROM [GetCustomerInfoView] WHERE [Active]=1 AND [Username]=@username";
            using (var conn = new SqlConnection(Runtime.ConnectionString))
            {
                conn.Open();
                return conn
                    .Query<GetCustomerCommandResult>(query, 
                    new { username = username })
                    .FirstOrDefault();
            }
        }
    }
}
