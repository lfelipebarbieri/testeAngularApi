using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    public class ContatoRepository : RepositoryBase<Contato>, IContatoRepository
    {
        public ContatoRepository(AngularContext Db)
            : base(Db)
        {
        }
    }
}
