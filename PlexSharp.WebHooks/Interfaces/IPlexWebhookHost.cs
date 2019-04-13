using Microsoft.AspNetCore.Builder;
using System;

namespace PlexSharp.Webhooks.Interfaces
{
    public interface IPlexWebhookHost
    {
        event EventHandler<PayloadEventArgs> OnPayloadReceived;
        event EventHandler OnMediaPlay;
        event EventHandler OnMediaPause;
        event EventHandler OnMediaResume;
        event EventHandler OnMediaStop;
        event EventHandler OnMediaScrobble;
        event EventHandler OnMediaRate;

        void Configure(IApplicationBuilder app);
    }
}
