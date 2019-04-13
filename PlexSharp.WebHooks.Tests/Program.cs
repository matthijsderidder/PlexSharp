using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace PlexSharp.Webhooks.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new PlexWebhookHost(CreateWebHostBuilder(args));
            host.OnPayloadReceived += (sender, e) => { Console.WriteLine(e.Payload); };
            host.OnMediaPlay += (sender, e) => { Console.WriteLine("Media Play"); };
            host.OnMediaPause += (sender, e) => { Console.WriteLine("Media Pause"); };
            host.OnMediaResume += (sender, e) => { Console.WriteLine("Media Resume"); };
            host.OnMediaStop += (sender, e) => { Console.WriteLine("Media Stop"); };
            host.OnMediaScrobble += (sender, e) => { Console.WriteLine("Media Scrobble"); };
            host.OnMediaRate += (sender, e) => { Console.WriteLine("Media Rate"); };

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel();
    }
}
