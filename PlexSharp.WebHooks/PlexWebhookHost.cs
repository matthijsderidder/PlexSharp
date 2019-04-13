using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PlexSharp.Webhooks.Interfaces;
using PlexSharp.Webhooks.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PlexSharp.Webhooks
{
    public class PlexWebhookHost : IPlexWebhookHost, IWebHost
    {
        #region Privates

        private readonly ILogger _logger;
        private readonly IConfiguration _config;
        private readonly IWebHost _host;
        private readonly string _field = "payload";

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public IFeatureCollection ServerFeatures => _host?.ServerFeatures;

        /// <summary>
        /// 
        /// </summary>
        public IServiceProvider Services => _host?.Services;

        #endregion

        #region Events

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<PayloadEventArgs> OnPayloadReceived;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler OnMediaPlay;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler OnMediaPause;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler OnMediaResume;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler OnMediaStop;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler OnMediaScrobble;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler OnMediaRate;

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public PlexWebhookHost(params string[] args)
            : this(WebHost.CreateDefaultBuilder(args))
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public PlexWebhookHost(IWebHostBuilder builder)
        {
            _host = builder.Configure(Configure).Build();
            _config = Services.GetRequiredService<IConfiguration>();
            _logger = Services.GetRequiredService<ILogger<PlexWebhookHost>>();
        }

        #endregion

        #region WebHost Methods

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            _host?.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return _host?.StartAsync(cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StopAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return _host?.StopAsync(cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            _host?.Dispose();
        }

        #endregion

        #region Webhook Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configure(IApplicationBuilder app)
        {
            app.MapWhen(context => context.Request.Method == "POST" && context.Request.Form.ContainsKey(_field), HandlePlex);

            app.Run(async (context) => {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("Bad Request");
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        private void HandlePlex(IApplicationBuilder app)
        {
            app.Run(async (context) => {

                try
                {
                    var str = context.Request.Form[_field];
                    HandlePayload(app, JsonConvert.DeserializeObject<Payload>(str));
                }
                catch(Exception ex)
                {
                    var msg = "Unable to deserialize response";
                    _logger.LogWarning(ex, msg);
                    await context.Response.WriteAsync(msg);
                    return;
                }

                await context.Response.WriteAsync("Hello, Plex!");
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="payload"></param>
        private void HandlePayload(IApplicationBuilder app, Payload payload)
        {
            _logger.LogInformation($"OnPayLoadReceived: {payload}");
            OnPayloadReceived?.Invoke(app, new PayloadEventArgs(payload));

            switch (payload.Event)
            {
                case EventType.MediaPlay:
                    OnMediaPlay?.Invoke(app, EventArgs.Empty);
                    break;

                case EventType.MediaPause:
                    OnMediaPause?.Invoke(app, EventArgs.Empty);
                    break;

                case EventType.MediaResume:
                    OnMediaResume?.Invoke(app, EventArgs.Empty);
                    break;

                case EventType.MediaStop:
                    OnMediaStop?.Invoke(app, EventArgs.Empty);
                    break;

                case EventType.MediaScrobble:
                    OnMediaScrobble?.Invoke(app, EventArgs.Empty);
                    break;

                case EventType.MediaRate:
                    OnMediaRate?.Invoke(app, EventArgs.Empty);
                    break;
            }
        }

        #endregion
    }
}
