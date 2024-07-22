using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ComplainSystem.Application.BusinessModels
{
    public class ProblemDetails
    {
        public Int32 statusCode { get; set; }
        public string? message { get; set; }
        public string? title { get; set; }
        public string? instance { get; set; }
        public string? details { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
