using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MyDevHelper2.Common
{
    public class Con
    {
        public string Name { get; set; }

    }
    public class ConConfig
    {
        public static List<Con> LoadAll()
        {
            List<Con> list = new List<Con>();
            XDocument xdoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "config\\ConList.config");
            XElement root = xdoc.Root;
            IEnumerable<XElement> cons = root.Elements("con");
            foreach (XElement ele in cons)
            {
                Con con = new Con();
                con.Name = ele.Attribute("name").Value;
                list.Add(con);
            }

            return list;
        }


        public static void AddValue(string name)
        {
            if(!IsExist(name))
            {
                XDocument xdoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "config\\ConList.config");
                XElement root = xdoc.Root;
                XElement cons = new XElement("con");
                cons.SetAttributeValue("name", name);
                root.Add(cons);
                xdoc.Save(AppDomain.CurrentDomain.BaseDirectory + "config\\ConList.config");
            }
        }

        public static bool IsExist(string name)
        {
            bool isexist = false;
            List<Con> list = LoadAll();

            foreach (var item in list)
            {
                if (item.Name.Trim().ToLower() == name.Trim().ToLower())
                {
                    isexist = true;
                    break;
                }
            }
            return isexist;
        }
    }
}