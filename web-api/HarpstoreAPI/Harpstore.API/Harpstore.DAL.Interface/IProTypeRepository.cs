using Harpstore.Domain;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Harpstore.DAL.Interface
{
    public interface IProTypeRepository
    {
        Task<IEnumerable<ProType>> GetAll();
        Task<ProType> GetById(int id);
        Task<ModifyProType> Save(ProType Request);
        Task<ModifyProType> Delete(int id);
    }
}
