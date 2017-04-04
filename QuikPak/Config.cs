using System.Collections.Generic;
using Newtonsoft.Json;
using WixSharp;

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
        public bool Enable64Bits { get; set; } = false;
        public IEnumerable<Cert> Certificates { get; set; }
    }

    public class Endpoint
    {
        public int Port { get; set; }
        public string DnsName { get; set; }
        public bool Secure { get; set; } = false;
    }

    public class Cert
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public string Password { get; set; }
        [JsonIgnore]
        public Binary BinaryKey { get; set; }
    }
}
