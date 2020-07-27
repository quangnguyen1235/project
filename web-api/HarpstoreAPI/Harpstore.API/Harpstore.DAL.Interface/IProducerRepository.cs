using Harpstore.Domain;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Harpstore.DAL.Interface
{
    public interface IProducerRepository
    {
        Task<IEnumerable<Producer>> GetAll();
        Task<Producer> GetById(int id);
        Task<ModifyProducer> Save(Producer Request);
        Task<ModifyProducer> Delete(int id);
    }
}
