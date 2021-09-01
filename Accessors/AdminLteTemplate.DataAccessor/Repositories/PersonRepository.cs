using AdminLteTemplate.DataAccessor.Context;
using AdminLteTemplate.DataAccessor.Contracts;
using AdminLteTemplate.DataAccessor.Models;
using GenericRepo.EFCore;
using System;
using System.Linq;

namespace AdminLteTemplate.DataAccessor.Repositories
{
    public class PersonRepository : GenericRepository<Person, DataContext>, IPersonRepository
    {
        public PersonRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
