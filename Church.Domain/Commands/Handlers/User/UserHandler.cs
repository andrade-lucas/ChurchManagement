using Church.Domain.Commands.Inputs.User;
using Church.Domain.Commands.Results.User;
using Church.Domain.Repositories;
using Church.Domain.ValueObjects;
using Church.Shared.Commands;

namespace Church.Domain.Commands.Handlers.User
{
    public class UserHandler : ICommandHandler<UserCreate>, ICommandHandler<UserDelete>, ICommandHandler<UserEdit>, ICommandHandler<UserFindById>, ICommandHandler<UserLogin>
    {
        private IUserRepository _userRepository;

        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ICommandResult Handle(UserCreate command)
        {
            Email email = new Email(command.Email);
            Document document = new Document(command.Document);

            Entities.User user = new Entities.User(command.ID, command.FirstName, command.LastName, command.Birthdate, command.Sex, email, command.Password, command.Status, command.Permission, document, command.Picture);

            _userRepository.Create(user);
            UserCreateCommandResult result = new UserCreateCommandResult();
            result.Message = "Usuário cadastrado com sucesso";

            return result;
        }

        public ICommandResult GetAllHandler()
        {
            UserGetAllCommandResult result = new UserGetAllCommandResult();
            result.Users = _userRepository.GetAll();
            return result;
        }

        public ICommandResult Handle(UserDelete command)
        {
            _userRepository.Delete(command.ID);
            UserDeleteCommandResult result = new UserDeleteCommandResult();
            result.Message = "Usuário deletado com sucesso";

            return result;
        }

        public ICommandResult Handle(UserEdit command)
        {
            Document document = new Document(command.Document);
            Email email = new Email(command.Email);

            Entities.User user = new Entities.User(command.ID, command.FirstName, command.LastName, command.Birthdate, command.Sex, email, command.Password, command.Status, command.Permission, document, command.Picture);
            _userRepository.Edit(user);
            UserEditCommandResult result = new UserEditCommandResult();
            result.Message = "Usuário editado com sucesso";

            return result;
        }

        public ICommandResult Handle(UserFindById command)
        {
            UserFindByIdCommandResult result = new UserFindByIdCommandResult();
            result.User = _userRepository.FindById(command.ID);

            return result;
        }

        public ICommandResult Handle(UserLogin command)
        {
            UserLoginCommandResult result = new UserLoginCommandResult();
            result.User = _userRepository.Login(command.Email, command.Senha);

            return result;
        }
    }
}
