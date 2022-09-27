using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using GOOModel;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Service Application To Upload GOO to bee node 
/// </summary>
namespace guarantees_of_origin
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Console.WriteLine("EX GOO Uploader");
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });

        static async Task Upload(string data)
        {

        }

        private static async Task<List<GOORoot>> ProcessUploads()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.energonx.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", "EnergonX Guarantees Of Origin Uploader");

            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = await JsonSerializer.DeserializeAsync<List<GOORoot>>(await streamTask);
            return repositories;
        }

    }
}
