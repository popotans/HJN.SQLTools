using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MyDevHelper2.Common
{
    public class Menu
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
    public class MenuConfig
    {
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public List<Menu> Menus { get; set; }

        public static List<MenuConfig> LoadAll()
        {
            List<MenuConfig> list = new List<MenuConfig>();
            XDocument xdoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "config\\menu.config");
            XElement root = xdoc.Root;
            IEnumerable<XElement> groups = root.Elements("group");
            foreach (XElement ele in groups)
            {
                string name = ele.Attribute("name").Value;
                string code = ele.Attribute("code").Value;
                MenuConfig cfg = new MenuConfig();
                cfg.GroupName = name;
                cfg.GroupCode = code;

                cfg.Menus = new List<Menu>();
                var eleMEuns = ele.Elements("menu");
                foreach (XElement menu in eleMEuns)
                {
                    Menu m = new Menu()
                    {
                        Link = menu.Value,
                        Name = menu.Attribute("name").Value
                    };
                    cfg.Menus.Add(m);
                }
                list.Add(cfg);
            }

            return list;
        }
    }
}