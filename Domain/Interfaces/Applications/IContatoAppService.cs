using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Applications
{
    public interface IContatoAppService : IAppServiceBase, IAppDataServiceBase<Contato>
    {
        List<Contato> ObterTodos();
        void Criar(Contato categoria);
        void Alterar(Contato categoria);
        void Excluir(Guid IdCategoria);
    }
}
