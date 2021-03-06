﻿using System;
using System.Collections.Generic;
using System.Text;
using IMQTTClientRx.Model;

namespace Test.Client.Core.Model
{
    internal class Options : TlsOptions, IClientOptions
    {
        public Uri Uri { get; internal set; }

        public string UserName { get; internal set; }
        public string Password { get; internal set; }
        public string ClientId { get; internal set; }
        public bool CleanSession { get; internal set; }
        public TimeSpan KeepAlivePeriod { get; internal set; }
        public TimeSpan DefaultCommunicationTimeout { get; internal set; }
        public ProtocolVersion ProtocolVersion { get; internal set; }
        public ConnectionType ConnectionType { get; internal set; }
    }
}
