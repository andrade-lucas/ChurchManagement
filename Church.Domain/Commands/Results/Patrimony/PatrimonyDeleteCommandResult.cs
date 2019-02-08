using Church.Shared.Commands;

namespace Church.Domain.Commands.Results.Patrimony
{
    public class PatrimonyDeleteCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
