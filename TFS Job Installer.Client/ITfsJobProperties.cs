using Microsoft.TeamFoundation.Framework.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFS_Job_Installer.Client
{
    public interface ITfsJobProperties
    {
        TeamFoundationJobDefinition JobDefinition { get; set; }
    }
}
