using Church.Shared.Commands;

namespace Church.Domain.Commands.Results.Patrimony
{
    public class PatrimonyFindByIdCommandResult : ICommandResult
    {
        public Entities.Patrimony Patrimony { get; set; }
    }
}
