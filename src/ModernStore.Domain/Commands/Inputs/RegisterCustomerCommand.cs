using TestFCamara.Shared.Commands;

namespace TestFCamara.Domain.Commands.Inputs
{
    public class RegisterCustomerCommand : ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
