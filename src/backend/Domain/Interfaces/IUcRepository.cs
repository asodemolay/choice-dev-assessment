using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Domain.Entities;

namespace backend.Domain.Interfaces
{
    public interface IUcRepository
    {
        //A better approach here should be using Tasks to execute Async methods. 
        IEnumerable<Uc> GetAll();
        Uc Get(long id);
    }
}
