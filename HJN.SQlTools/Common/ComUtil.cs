using PWMIS.DataProvider.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace MyDevHelper2.Common
{
    public class ComUtil
    {
        public static MemoryStream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static string GetVal(DataRow dr, DataColumn dc)
        {
            object v = dr[dc.ColumnName];
            string s = "";
            if (dc.DataType == typeof(string) || dc.DataType == typeof(Guid))
                s = "N'" + v.ToString().Replace("'", "''") + "'";
            else if (v.GetType() == typeof(DBNull))
            {
                s = "NULL";
            }
            else if (v.GetType() == typeof(DateTime))
            {
                s = "N'" + v.ToString() + "'";
            }
            else if (v.GetType() == typeof(bool))
            {
                s = v.ToString().ToLower() == "true" ? "1" : "0";
            }
            else s = v.ToString() + "";
            return s;
        }

        public static DataTable GetColumnDT(string dbtable, AdoHelper db)
        {
            DataTable dt = new DataTable();
            string sql = @"
select
     c.name as [字段名],t.name as [字段类型]
     ,convert(bit,c.IsNullable)  as [可否为空]
     ,convert(bit,case when exists(select 1 from sysobjects where xtype='PK' and parent_obj=c.id and name in (
         select name from sysindexes where indid in(
             select indid from sysindexkeys where id = c.id and colid=c.colid))) then 1 else 0 end) 
                 as [是否主键]
     ,convert(bit,COLUMNPROPERTY(c.id,c.name,'IsIdentity')) as [自动增长]
     ,c.Length as [占用字节] 
     ,COLUMNPROPERTY(c.id,c.name,'PRECISION') as [长度]
     ,isnull(COLUMNPROPERTY(c.id,c.name,'Scale'),0) as [小数位数]
     ,ISNULL(CM.text,'') as [默认值]
     ,isnull(ETP.value,'') AS [字段描述]
     --,ROW_NUMBER() OVER (ORDER BY C.name) AS [Row]
from syscolumns c
inner join systypes t on c.xusertype = t.xusertype 
left join sys.extended_properties ETP on ETP.major_id = c.id and ETP.minor_id = c.colid and ETP.name ='MS_Description' 
left join syscomments CM on c.cdefault=CM.id
where c.id = object_id('#tb#')
order by c.id asc";

            sql = sql.Replace("#tb#", dbtable);

            dt = db.ExecuteDataSet(sql).Tables[0];

            return dt;
        }

    }
}
