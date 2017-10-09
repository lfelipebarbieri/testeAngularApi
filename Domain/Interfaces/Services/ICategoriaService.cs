using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface ICategoriaService : IDataServiceBase<Categoria>
    {
        List<Categoria> ObterTodas();
    }
}
