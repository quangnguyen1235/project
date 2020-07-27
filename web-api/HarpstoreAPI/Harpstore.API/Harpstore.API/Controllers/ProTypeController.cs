using Harpstore.BAL.Interface;
using Harpstore.DAL;
using Harpstore.DAL.Interface;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harpstore.API.Controllers
{
    public class ProTypeController : ControllerBase
    {
        private readonly IProTypeService proTypeService;
        private readonly ILogger<ProTypeController> logger;
        public ProTypeController(IProTypeService proTypeService, ILogger<ProTypeController> logger)
        {
            this.proTypeService = proTypeService;
            this.logger = logger;
        }
        [HttpDelete]
        [Route("/api/protype/delete/{id}")]
        public async Task<ModifyProType> Delete(int id)
        {
            return await proTypeService.Delete(id);
        }
        [HttpGet]
        [Route("/api/protype/getAll")]
        public async Task<IEnumerable<ProType>> GetAll()
        {
            return await proTypeService.GetAll();
        }
        [HttpGet]
        [Route("/api/protype/getById/{id}")]
        public async Task<ProType> GetById(int id)
        {
            return await proTypeService.GetById(id);
        }
        [HttpPost]
        [Route("/api/protype/save")]
        public async Task<ModifyProType> Save(ProType Request)
        {
            return await proTypeService.Save(Request);
        }
    }
}
