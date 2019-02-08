using Church.Shared.Commands;

namespace Church.Domain.Commands.Inputs.Patrimony
{
    public class PatrimonyDelete : ICommand
    {
        public string ID { get; set; }
    }
}
