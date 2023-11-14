using EasyAutomationFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraping.Model;

namespace WebScraping.Driver
{
    public class WebScraper : Web
    {
        public DataTable GetData(string url)
        {
            if (driver == null) StartBrowser();

            var items = new List<Item>();

            Navigate(url);

            var elements = GetValue(TypeElement.Xpath, "/html/body/app-root/div/div/div/app-cabecalho-compra-acesso-publico/div[2]/app-compra-acesso-publico/div/p-tabview/div/div/p-tabpanel/div/app-itens-acesso-publico")
                            .element.FindElements(By.TagName("app-card-item"));

            foreach (var element in elements)
            {
                var item = new Item();
                item.Titulo = element.FindElement(By.ClassName("text-uppercase")).Text;

                items.Add(item);
            }

            return Base.ConvertTo(items);
        }
    }
}
