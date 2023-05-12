using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CQRS.Commands
{
    public class CommandResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
