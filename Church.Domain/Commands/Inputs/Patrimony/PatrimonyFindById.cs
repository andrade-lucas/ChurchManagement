using Church.Shared.Commands;

namespace Church.Domain.Commands.Inputs.Patrimony
{
    public class PatrimonyFindById : ICommand
    {
        public string ID { get; set; }
    }
}
