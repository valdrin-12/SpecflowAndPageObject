using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CsharpSelenium2022.Hooks
{
    [Binding]
    public sealed class Hooks1:DriverHelper
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {

            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
           // option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            Console.WriteLine("Setup");
            Driver = new ChromeDriver(option);
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();  
        }
    }
}