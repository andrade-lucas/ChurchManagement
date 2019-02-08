using Church.Shared.Commands;
using System;

namespace Church.Domain.Commands.Inputs.Patrimony
{
    public class PatrimonyCreate : ICommand
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string Lot { get; set; }
        public DateTime DateOfAcquisition { get; set; }
        public string Observation { get; set; }
    }
}
