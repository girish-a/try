using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace TemplateManagement.Core.Tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class TemplateManagerTests
    {

        [Fact]
        public void TestTemplateManager()
        {
            RazorTemplateManager rtm = new RazorTemplateManager();
            string result = rtm.Parse();
        }
    }
}
