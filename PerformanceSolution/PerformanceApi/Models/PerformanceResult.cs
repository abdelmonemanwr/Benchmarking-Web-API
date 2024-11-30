using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable
namespace PerformanceApi.Models
{
    public class PerformanceResult
    {
        public string Method { get; set; }
        public string Result { get; set; }
        public long DurationMs { get; set; }
    }
}