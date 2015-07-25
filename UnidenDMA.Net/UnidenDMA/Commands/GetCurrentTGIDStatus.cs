using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnidenDMA.Constants;

namespace UnidenDMA.Commands
{
    public class GetCurrentTGIDStatus : Command
    {
        private const string CMD = "GID";
        public SiteType SiteType { get; set; }
        public int TGID { get; set; }
        public string SystemSiteName { get; set; }
        public string GroupName { get; set; }
        public string TGIDName { get; set; }

        public override string CommandText
        {
            get
            {
                return String.Join(",", CMD, SiteType.ToString(), TGID.ToString(), SystemSiteName, GroupName, TGIDName);
            }
        }
    }
}
