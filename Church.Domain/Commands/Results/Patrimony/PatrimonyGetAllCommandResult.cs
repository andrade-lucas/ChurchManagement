using Church.Shared.Commands;
using System.Collections.Generic;

namespace Church.Domain.Commands.Results.Patrimony
{
    public class PatrimonyGetAllCommandResult : ICommandResult
    {
        public List<Entities.Patrimony> Patrimonies { get; set; }
    }
}
