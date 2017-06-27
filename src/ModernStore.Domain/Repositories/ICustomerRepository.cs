using System;
using TestFCamara.Domain.Commands.Results;
using TestFCamara.Domain.Entities;

namespace TestFCamara.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(Guid id);
        Customer GetByUsername(string username);
        GetCustomerCommandResult Get(string username);
        void Save(Customer customer);
        void Update(Customer customer);        
    }
}
