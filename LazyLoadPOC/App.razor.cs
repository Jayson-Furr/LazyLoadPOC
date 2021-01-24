using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Services;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LazyLoadPOC
{
    public partial class App : ComponentBase
    {
        [Inject()]
        private LazyAssemblyLoader LazyAssemblyLoader { get; set; }

        public bool Added { get; set; }

        private List<Assembly> LazyLoadedAssemblies { get; set; } = new List<Assembly>();

        private async Task HandleNavigateAsync(NavigationContext navigationContext)
        {
            if (navigationContext.Path.StartsWith("counter", StringComparison.OrdinalIgnoreCase))
            {
                await LazyAssemblyLoader.LoadAssembliesAsync(new List<string> { "SampleService.Real.dll" });
            }
        }
    }
}
