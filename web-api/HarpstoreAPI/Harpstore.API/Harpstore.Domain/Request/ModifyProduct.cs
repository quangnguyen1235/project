using System;

namespace Harpstore.Domain.Request
{
    public class ModifyProduct
    {
        public int ProductId { get; set; }
        public string Message { get; set; }
    }
}
