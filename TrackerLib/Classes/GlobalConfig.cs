using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.DataAccess;

namespace TrackerLib.Classes
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }
        public static void InitializeConnections()
        {
            SqlConnector sql = new SqlConnector();
            Connections.Add(sql);
        }
    }
}
