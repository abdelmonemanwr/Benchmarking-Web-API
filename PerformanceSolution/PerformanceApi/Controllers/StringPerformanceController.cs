using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerformanceApi.Models;

namespace PerformanceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StringPerformanceController : ControllerBase
    {
        // Endpoint 1: String Concatination
        [HttpGet("concat")]
        public ActionResult<PerformanceResult> ConcatenateString()
        {
            var stopwatch = Stopwatch.StartNew();
            string result = string.Empty;

            for (int i = 0; i < 1000; i++)
            {
                result += "sample";
            }

            stopwatch.Stop();
            PerformanceResult response = new PerformanceResult
            {
                Method = "String Concatenation",
                Result = result.Substring(0, 10) + "...",
                DurationMs = stopwatch.ElapsedMilliseconds
            };

            return Ok(response);
        }

        // Endpoint 2: StringBuilder
        [HttpGet("stringbuilder")]
        public ActionResult<PerformanceResult> UseStringBuilder()
        {
            var stopwatch = Stopwatch.StartNew();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                builder.Append("sample");
            }

            stopwatch.Stop();
            PerformanceResult response = new PerformanceResult
            {
                Method = "StringBuilder",
                Result = builder.ToString().Substring(0, 10) + "...",
                DurationMs = stopwatch.ElapsedMilliseconds
            };

            return Ok(response);
        }
    }
}