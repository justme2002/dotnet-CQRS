using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CQRS.Commands
{
    public interface ICommandBus
    {
        Task<CommandResult> SendAsync(ICommand command);
    }
}
