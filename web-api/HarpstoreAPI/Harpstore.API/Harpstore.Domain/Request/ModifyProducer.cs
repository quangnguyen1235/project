using System;

namespace Harpstore.Domain.Request
{
    public class ModifyProducer
    {
        public int ProducerId { get; set; }
        public string Message { get; set; }
    }
}
