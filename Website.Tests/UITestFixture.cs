using Atata;
using OpenQA.Selenium.Chrome;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtataUITests1
{
    public class UITestFixture
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]        
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = AppDomain.CurrentDomain.BaseDirectory + @"chromium\chrome.exe";

            // Find information about AtataContext set-up on https://atata-framework.github.io/getting-started/#set-up.
            AtataContext.Configure().
                UseChrome().
                    WithOptions(() => options).
                    WithArguments("start-maximized", "headless").
                    WithFixOfCommandExecutionDelay().
                    WithLocalDriverPath().
                UseBaseUrl("https://www.visualstudio.com/team-services/").
                UseTestName(TestContext.TestName).
                AddTraceLogging().
                Build();
        }

        [TestCleanup]
        public void TearDown()
        {
            AtataContext.Current.CleanUp();
        }
    }
}
