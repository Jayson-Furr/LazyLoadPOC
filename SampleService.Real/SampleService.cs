using SampleService.Interfaces;

using System;

namespace SampleService.Real
{
    public class SampleService : ISampleService
    {
        public SampleService()
        {
            Name = $"Name From Real Sample Service {Guid.NewGuid()}";
        }

        public string Name { get; set; }
    }
}
