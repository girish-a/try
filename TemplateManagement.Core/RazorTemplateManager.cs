using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateManagement.Core
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class RazorTemplateManager
    {
        public RazorTemplateManager()
        {
        }

        public string Parse()
        {
            TemplateService templateService = new TemplateService();
            string templateName = "TestTemplate";
            string body = "@model dynamic" + Environment.NewLine + "<html>Hello, @Model.CustomerName!</html>";
            dynamic model = new { CustomerName = "Girish" };

            var result = templateService.Parse(body, model, null, templateName);
            return result;
        }
    }
}
