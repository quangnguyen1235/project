using Harpstore.BAL.Interface;
using Harpstore.DAL.Interface;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Haspstore.BAL
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository producerRepository;

        public ProducerService(IProducerRepository producerRepository)
        {
            this.producerRepository = producerRepository;
        }

        public async Task<ModifyProducer> Delete(int id)
        {
            return await producerRepository.Delete(id);
        }

        public async Task<IEnumerable<Producer>> GetAll()
        {
            return await producerRepository.GetAll();
        }

        public async Task<Producer> GetById(int id)
        {
            return await producerRepository.GetById(id);
        }

        public async Task<ModifyProducer> Save(Producer request)
        {
            return await producerRepository.Save(request);
        }
    }
}
