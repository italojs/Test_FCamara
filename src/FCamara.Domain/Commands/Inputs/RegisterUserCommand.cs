using FCamaraProject.Shared.Commands;

namespace FCamaraProject.Domain.Commands.Inputs
{
    public class RegisterUserCommand : ICommand
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
