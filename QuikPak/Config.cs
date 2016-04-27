using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikPak
{
	public class Config
	{
		public string Id { get; set; }
		public string UpgradeCode { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
		public ICollection<Endpoint> Endpoints { get; set; }
	}

	public class Endpoint
	{
		public string Port { get; set; }
		public string DnsName { get; set; }
		public bool Secure { get; set; } = false;
	}
}
