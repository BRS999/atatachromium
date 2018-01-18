using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Atata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtataUITests1
{
    public class HomeTests : UITestFixture
    {
        [Test]
        [Category("Smoke")]
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
