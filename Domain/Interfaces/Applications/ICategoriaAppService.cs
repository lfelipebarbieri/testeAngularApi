using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Applications
{
    public interface ICategoriaAppService : IAppServiceBase, IAppDataServiceBase<Categoria>
    {
        List<Categoria> ObterTodas();
        void Criar(Categoria categoria);
        void Alterar(Categoria categoria);
        void Excluir(Guid IdCategoria);
    }
}
