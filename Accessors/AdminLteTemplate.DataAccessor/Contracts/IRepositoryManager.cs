using AdminLteTemplate.DataAccessor.Contracts;
using System;
using System.Linq;

namespace AdminLteTemplate.DataAccessor.Contracts
{
    public interface IRepositoryManager
    {
        IPersonRepository People { get; }
    }
}
