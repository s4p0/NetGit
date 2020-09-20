using LiteDB;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace NetGit.Web.Database
{
    public class LiteDBContext
    {
        public LiteDatabase Context { get; }

        public LiteDBContext(IOptions<LiteDbConfig> config)
        {
            Context = new LiteDB.LiteDatabase(config.Value.Path);
        }

    }
}
