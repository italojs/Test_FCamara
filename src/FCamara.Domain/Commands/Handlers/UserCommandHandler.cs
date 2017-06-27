using FluentValidator;
using FCamaraProject.Domain.Commands.Inputs;
using FCamaraProject.Domain.Commands.Results;
using FCamaraProject.Domain.Entities;
using FCamaraProject.Domain.Repositories;
using FCamaraProject.Shared.Commands;

namespace FCamaraProject.Domain.Commands.Handlers
{
    public class UserCommandHandler : Notifiable,
        ICommandHandler<RegisterUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public UserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ICommandResult Handle(RegisterUserCommand command)
        {

            var user = new User(command.Username, command.Password);

            AddNotifications(user.Notifications);

            if (!IsValid())
                return null;

            // Passo 4. Inserir no banco
            _userRepository.Save(user);

            // Passo 6. Retornar algo
            return new RegisterUserCommandResult(user.Id, user.Username.ToString());
        }
    }
}
