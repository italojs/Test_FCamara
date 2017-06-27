using System;
using System.Collections.Generic;
using TestFCamara.Domain.Commands.Results;
using TestFCamara.Domain.Entities;

namespace TestFCamara.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(Guid id);
        IEnumerable<GetProductListCommandResult> Get();
    }
}
