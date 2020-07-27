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
using System.Runtime.InteropServices.WindowsRuntime;

namespace Harpstore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducerController : ControllerBase
    {
        private readonly ILogger<ProducerController> logger;
        private readonly IProducerService producerService;
        public ProducerController(IProducerService producerService, ILogger<ProducerController> logger)
        {
            this.producerService = producerService;
            this.logger = logger;
        }
        [HttpGet]
        [Route("/api/producer/getAll")]
        public async Task<IEnumerable<Producer>> GetAll()
        {
            return await producerService.GetAll();
        }
        [HttpGet]
        [Route("/api/producer/getById/{id}")]
        public async Task<Producer> GetById(int id)
        {
            return await producerService.GetById(id);
        }
        [HttpPost]
        [Route("/api/producer/save")]
        public async Task<ModifyProducer> Save(Producer Request)
        {
            return await producerService.Save(Request);
        }
        [HttpDelete]
        [Route("/api/producer/delete/{id}")]
        public async Task<ModifyProducer> Delete(int id)
        {
            return await producerService.Delete(id);
        }
    }
}
