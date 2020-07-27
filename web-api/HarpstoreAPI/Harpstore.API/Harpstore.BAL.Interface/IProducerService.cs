
using Harpstore.Domain;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Harpstore.BAL.Interface
{
    public interface IProducerService
    {
        Task<IEnumerable<Producer>> GetAll();
        Task<Producer> GetById(int id);
        Task<ModifyProducer> Save(Producer Request);
        Task<ModifyProducer> Delete(int id);
    }
}
