using Atata;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace AtataUITests1
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
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
                UseCulture("en-us").
                UseNUnitTestName().
                AddScreenshotFileSaving().
                        WithFolderPath(() => $@"Logs\{AtataContext.BuildStart:yyyy-MM-dd HH_mm_ss}\{AtataContext.Current.TestName}").
                AddNUnitTestContextLogging().
                LogNUnitError().
                TakeScreenshotOnNUnitError().
                Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current.CleanUp();
        }
    }
}
