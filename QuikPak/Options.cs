using CommandLine;
using CommandLine.Text;
using System.Collections.Generic;

namespace QuikPak
{
    public class Options
    {
        [Option('x', "path", Required = true, HelpText = "path to files")]
        public string Path { get; set; }

        [Option('c', "config", Required = true, HelpText = "path to a config")]
        public string Config { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this);
        }
    }
}
