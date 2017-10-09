using Domain.Entities;
using Domain.Interfaces.Services;

namespace Services
{
    public class UsuarioService : DataServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUnitOfWorkService _uow;

        public UsuarioService(UnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
        }
    }
}
