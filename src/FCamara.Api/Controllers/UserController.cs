using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FCamaraProject.Domain.Commands.Handlers;
using FCamaraProject.Domain.Commands.Inputs;
using FCamaraProject.Infra.Transactions;

namespace FCamaraProject.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly UserCommandHandler _handler;

        public UserController(IUow uow, UserCommandHandler handler)
            :base(uow)
        {
            _handler = handler;
        }

        [HttpPost]
        [Route("v1/register/user")]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody]RegisterUserCommand command)
        {
            var result = _handler.Handle(command);
            return await Response(result, _handler.Notifications);
        }
    }
}