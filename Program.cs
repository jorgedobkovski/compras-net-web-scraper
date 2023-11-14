using EasyAutomationFramework;
using EasyAutomationFramework.Model;
using WebScraping.Driver;

var web = new WebScraper();

var itens = web.GetData("https://cnetmobile.estaleiro.serpro.gov.br/comprasnet-web/public/compras/acompanhamento-compra?compra=92537305003012023");

var paramss = new ParamsDataTable("Dados3", @"C:\temp\excel", new List<DataTables>()
{
    new DataTables("itens", itens),
});

Base.GenerateExcel(paramss);