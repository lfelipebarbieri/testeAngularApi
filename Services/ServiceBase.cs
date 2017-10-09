using Domain.Interfaces.Services;

namespace Services
{
    public class ServiceBase : IServiceBase
    {
        private IUnitOfWorkService _uow;
        public ServiceBase(IUnitOfWorkService uow)
        {
            _uow = uow;
        }
    }
}
