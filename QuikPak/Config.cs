using System.Collections.Generic;

namespace QuikPak
{
    public class Config
    {
        public string Id { get; set; }
        public string UpgradeCode { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public ICollection<Endpoint> Endpoints { get; set; }

        public string Identity { get; set; } = "localSystem";
        public int RecycleMinutes { get; set; } = 0;
        public int IdleTimeout { get; set; } = 0;
        public string ManagedPipelineMode { get; set; } = "Integrated";
        public string ManagedRuntimeVersion { get; set; } = "v4.0";
        public ICollection<Cert> Certificates { get; set; } = new HashSet<Cert>();
    }

    public class Endpoint
    {
        public int Port { get; set; }
        public string DnsName { get; set; }
        public bool Secure { get; set; } = false;
    }
}