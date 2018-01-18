using System;
using System.Collections.Generic;
using System.Text;
using Atata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtataUITests1
{
    [TestClass]
    public class HomeTests : UITestFixture
    {
        [TestMethod]
        [TestCategory("Smoke")]
        public void Home()
        {
            Go.To<HomePage>()
                .Wait(2)
                .PageTitle.Should.Contain("Visual Studio Team Services")
                .Should.Exist();
        }
    }
}
