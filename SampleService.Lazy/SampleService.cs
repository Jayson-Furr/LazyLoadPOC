
using SampleService.Interfaces;

namespace SampleService.Lazy
{
    public class SampleService : ISampleService
    {
        private dynamic _dynamicSampleService = null;
        private dynamic DynamicSampleService 
        {
            get
            {
                if (_dynamicSampleService == null)
                {
                    _dynamicSampleService = new Real.SampleService();
                }
                return _dynamicSampleService;
            }
        }

        public string Name
        {
            get
            {
                return DynamicSampleService.Name;
            }
            set
            {
                DynamicSampleService.Name = value;
            }
        }
    }
}