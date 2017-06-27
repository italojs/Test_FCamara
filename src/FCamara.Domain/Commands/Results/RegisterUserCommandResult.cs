using System;
using FCamaraProject.Shared.Commands;

namespace FCamaraProject.Domain.Commands.Results
{
    public class RegisterUserCommandResult : ICommandResult
    {
        public RegisterUserCommandResult()
        {
            
        }
        public RegisterUserCommandResult(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
