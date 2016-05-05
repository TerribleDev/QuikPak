using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikPak
{
    public static class Verifier
    {
        public static void Verify(Config config)
        {
            if(string.IsNullOrWhiteSpace(config.UpgradeCode))
            {
                throw new Exception("Upgrade code required");
            }
            foreach(var certificate in config.Certificates)
            {
                if(string.IsNullOrWhiteSpace(certificate.CertificatePath) || !File.Exists(certificate.CertificatePath))
                {
                    throw new Exception("Certificate path could not be found");
                }
            }
        }
    }
}