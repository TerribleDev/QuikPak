using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikPak
{
    public class Certificate : IEquatable<Certificate>
    {
        public string CertificatePath { get; set; }
        public string PfxPassword { get; set; }

        public bool Equals(Certificate other)
        {
            return string.Equals(this.CertificatePath, other.CertificatePath);
        }

        public override int GetHashCode()
        {
            return new { CertificatePath, PfxPassword }.GetHashCode();
        }
    }
}