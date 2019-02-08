using Church.Shared.Commands;

namespace Church.Domain.Commands.Results.Patrimony
{
    public class PatrimonyCreateCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
