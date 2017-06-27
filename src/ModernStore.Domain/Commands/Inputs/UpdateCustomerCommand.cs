using System;
using TestFCamara.Shared.Commands;

namespace TestFCamara.Domain.Commands.Inputs
{
    public class UpdateCustomerCommand : ICommand
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
