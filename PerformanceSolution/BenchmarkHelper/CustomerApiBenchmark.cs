using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace BenchmarkHelper
{
    [MemoryDiagnoser]
    public class CustomerApiBenchmark
    {
        private readonly HttpClient _httpClient;

        public CustomerApiBenchmark()
        {
            _httpClient = new HttpClient();
        }

        [Benchmark]
        public async Task TestStringConcatenationEndpoint()
        {
            var response = await _httpClient.GetAsync("http://localhost:5241/api/StringPerformance/concat");
            response.EnsureSuccessStatusCode();
        }

        [Benchmark]
        public async Task TestStringBuilderConcatenationEndpoint()
        {
            var response = await _httpClient.GetAsync("http://localhost:5241/api/StringPerformance/stringbuilder");
            response.EnsureSuccessStatusCode();
        }
    }
}