using FluentValidator;
using TestFCamara.Domain.Commands.Inputs;
using TestFCamara.Domain.Commands.Results;
using TestFCamara.Domain.Entities;
using TestFCamara.Domain.Repositories;
using TestFCamara.Domain.ValueObjects;
using TestFCamara.Shared.Commands;

namespace TestFCamara.Domain.Commands.Handlers
{
    public class CustomerCommandHandler : Notifiable,
        ICommandHandler<RegisterCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public ICommandResult Handle(RegisterCustomerCommand command)
        {

            var name = new Name(command.FirstName, command.LastName);
            var user = new User(command.Username, command.Password);
            var customer = new Customer(name, user);

            AddNotifications(name.Notifications);
            AddNotifications(user.Notifications);
            AddNotifications(customer.Notifications);

            if (!IsValid())
                return null;

            _customerRepository.Save(customer);

            return new RegisterCustomerCommandResult(customer.Id, customer.Name.ToString());
        }
    }
}
