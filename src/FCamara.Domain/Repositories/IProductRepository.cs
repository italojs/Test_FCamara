using System;
using System.Collections.Generic;
using FCamaraProject.Domain.Commands.Results;
using FCamaraProject.Domain.Entities;

namespace FCamaraProject.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(Guid id);
        IEnumerable<GetProductListCommandResult> Get();
    }
}
