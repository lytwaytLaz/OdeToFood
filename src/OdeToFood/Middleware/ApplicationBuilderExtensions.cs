using Microsoft.Extensions.FileProviders;
using System.IO;

// When writing an Extension to IApplicationBuilder it is a convention
// to put the extension in the same namespace as IApplicationBuilder.
// That makes the extension method easy to find
namespace Microsoft.AspNetCore.Builder

{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            var path = Path.Combine(root, "node_modules");
            var provider = new PhysicalFileProvider(path);
            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            options.FileProvider = provider;

            app.UseStaticFiles(options);

            return app;
        }
    }
}
