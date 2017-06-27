using System;
using FCamaraProject.Domain.Commands.Results;
using FCamaraProject.Domain.Entities;

namespace FCamaraProject.Domain.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid id);
        void Save(User user);
        User GetByUsername(string username);
    }
}
