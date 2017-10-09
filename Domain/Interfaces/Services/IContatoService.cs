using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IContatoService : IDataServiceBase<Contato>
    {
        List<Contato> ObterTodos();
    }
}
