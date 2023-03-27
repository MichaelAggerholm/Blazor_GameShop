using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Shared
{
    public class ServiceResponse<T>
    {
        // T er en generisk type, som kan bruges til at definere hvilken type data der skal returneres
        public T? Data { get; set; }

        public bool Success { get; set; } = true;

        public string Message { get; set; } = string.Empty;
    }
}
