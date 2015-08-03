using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TFS_Job_Installer
{
    class Program
    {
        const string ToolsPath = @"C:\Program Files\Microsoft Team Foundation Server 14.0\Tools";

        static void Main(string[] args)
        {
            var appExe = new FileInfo(Assembly.GetExecutingAssembly().Location);
            if (string.Compare(appExe.Directory.FullName.TrimEnd('\\'), ToolsPath, StringComparison.InvariantCultureIgnoreCase) != 0)
            {
                Console.WriteLine($"This tool can only be run from {ToolsPath}.");
            }
        }
    }
}
