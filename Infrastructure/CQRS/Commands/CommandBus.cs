using Domain.Seedworks;
using Infrastructure.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CQRS.Commands
{
    public class CommandBus : ICommandBus
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;
        public CommandBus(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
        }
        public async Task<CommandResult> SendAsync(ICommand command)
        {
            await this.unitOfWork.saveChangeAsync(() => this.mediator.Send(command));
            return new CommandResult
            {
                IsSuccess = true
            };
        }
    }
}
 