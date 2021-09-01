using AdminLteTemplate.DataAccessor.Context;
using AdminLteTemplate.DataAccessor.Contracts;
using System;
using System.Linq;

namespace AdminLteTemplate.DataAccessor.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        private IPersonRepository _personRepository;

        public RepositoryManager(DataContext context)
        {
            _context = context;
        }

        public IPersonRepository People
        {

            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(_context);
                }

                return _personRepository;
            }

        }
    }
}
