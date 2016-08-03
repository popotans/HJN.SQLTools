using PWMIS.Core.YueWen.DataProvider;
using PWMIS.DataProvider.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MyDevHelper2.Common
{
    public class DBContext
    {
  
        public static YwDb GetDB(string connstr)
        {
            YwDb db = new YwSqlServer();
            db.ConnectionString = connstr;
            return db;
        }
    }
    public class DBCon
    {
       
        public string server { get; set; }
        public string uid { get; set; }
        public string database { get; set; }
        public string password { get; set; }

        public string BuildCon()
        {
            return string.Format("server ={0}; uid={1};database={2}; password={3}", server, uid, database, password);
        }
       
    }

}