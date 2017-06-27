using System;
using System.Linq;
using FCamaraProject.Domain.Entities;
using FCamaraProject.Domain.Repositories;
using FCamaraProject.Infra.Contexts;

namespace FCamaraProject.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FCamaraDataContext _context;

        public UserRepository(FCamaraDataContext context)
        {
            _context = context;
        }

        public User Get(Guid id)
        {
            return null;
        }

        public User GetByUsername(string username)
        {
            return _context.Users.Where(p => p.Username == username).FirstOrDefault();
        }

        public void Save(User user)
        {
            _context.Users.Add(user);
        }

    }
}
