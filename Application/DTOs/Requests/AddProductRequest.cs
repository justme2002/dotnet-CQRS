using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Requests
{
    public class AddProductRequest
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
    }
}
