using PlexSharp.Webhooks.Models;
using System;

namespace PlexSharp.Webhooks
{
    public class PayloadEventArgs : EventArgs
    {
        public Payload Payload { get; internal set; }

        public PayloadEventArgs(Payload payload) : base()
        {
            Payload = payload;
        }
    }
}
