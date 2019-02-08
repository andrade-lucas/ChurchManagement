using Church.Domain.Commands.Inputs.Patrimony;
using Church.Domain.Commands.Results.Patrimony;
using Church.Domain.Repositories;
using Church.Shared.Commands;

namespace Church.Domain.Commands.Handlers.Patrimony
{
    public class PatrimonyHandler : ICommandHandler<PatrimonyCreate>, ICommandHandler<PatrimonyEdit>, ICommandHandler<PatrimonyFindById>, ICommandHandler<PatrimonyDelete>
    {
        private readonly IGenericRepository<Entities.Patrimony> _patrimonyRepository;

        public PatrimonyHandler(IGenericRepository<Entities.Patrimony> patrimonyRepository)
        {
            _patrimonyRepository = patrimonyRepository;
        }

        public ICommandResult Handle(PatrimonyCreate command)
        {
            Entities.Patrimony patrimony = new Entities.Patrimony(command.ID, command.Description, command.Lot, command.DateOfAcquisition, command.Observation);
            _patrimonyRepository.Create(patrimony);

            PatrimonyCreateCommandResult result = new PatrimonyCreateCommandResult();
            result.Message = "Patrimônio cadastrado com sucesso";

            return result;
        }

        public ICommandResult Handle(PatrimonyEdit command)
        {
            Entities.Patrimony patrimony = new Entities.Patrimony(command.ID, command.Description, command.Lot, command.DateOfAcquisition, command.Observation);
            _patrimonyRepository.Edit(patrimony);

            PatrimonyEditCommandResult result = new PatrimonyEditCommandResult();
            result.Message = "Patrimônio editado com sucesso";

            return result;
        }

        public ICommandResult Handle(PatrimonyFindById command)
        {
            PatrimonyFindByIdCommandResult result = new PatrimonyFindByIdCommandResult();
            result.Patrimony = _patrimonyRepository.FindById(command.ID);

            return result;
        }

        public ICommandResult Handle(PatrimonyDelete command)
        {
            _patrimonyRepository.Delete(command.ID);
            PatrimonyDeleteCommandResult result = new PatrimonyDeleteCommandResult();
            result.Message = "Patrimônio deletado com sucesso";

            return result;
        }

        public ICommandResult GetAllHandler()
        {
            PatrimonyGetAllCommandResult result = new PatrimonyGetAllCommandResult();
            result.Patrimonies = _patrimonyRepository.GetAll();

            return result;
        }
    }
}
