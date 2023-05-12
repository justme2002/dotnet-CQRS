using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CQRS.Commands
{
    public interface ICommand : IRequest<CommandResult>
    {

    }
}
