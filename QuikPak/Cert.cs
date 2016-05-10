using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikPak
{
    public class Cert : IEquatable<Cert>
    {
        public string CertificatePath { get; set; }
        public string PfxPassword { get; set; }

        public bool Equals(Cert other)
        {
            return string.Equals(this.CertificatePath, other.CertificatePath);
        }

        public override int GetHashCode()
        {
            return new { CertificatePath, PfxPassword }.GetHashCode();
        }
    }
}