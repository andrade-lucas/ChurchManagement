using Church.Shared.Entities;
using System;

namespace Church.Domain.Entities
{
    public class Patrimony : Entity
    {
        public string Description { get; private set; }
        public string Lot { get; private set; }
        public DateTime DateOfAcquisition { get; private set; }
        public string Observation { get; private set; }

        public Patrimony()
        {
        }

        public Patrimony(string id, string description, string lot, DateTime dateOfAcquisition, string observation) : base(id)
        {
            Description = description;
            Lot = lot;
            DateOfAcquisition = dateOfAcquisition;
            Observation = observation;
        }
    }
}
