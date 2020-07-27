using Harpstore.BAL.Interface;
using Harpstore.DAL.Interface;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Harpstore.BAL
{
    public class ProTypeService : IProTypeService
    {
        private readonly IProTypeRepository proTypeRepository;

        public ProTypeService(IProTypeRepository proTypeRepository)
        {
            this.proTypeRepository = proTypeRepository;
        }

        public async Task<ModifyProType> Delete(int id)
        {
            return await proTypeRepository.Delete(id);
        }

        public async Task<IEnumerable<ProType>> GetAll()
        {
            return await proTypeRepository.GetAll();
        }

        public async Task<ProType> GetById(int id)
        {
            return await proTypeRepository.GetById(id);
        }

        public async Task<ModifyProType> Save(ProType request)
        {
            return await proTypeRepository.Save(request);
        }
    }
}
