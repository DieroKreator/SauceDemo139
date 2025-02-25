using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace StepDefinitionsPO
{
    [Binding]
    public class Hooks
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver driver;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void ScenarioSetup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            driver.Manage().Window.Maximize();
            // Specific for C#
            _scenarioContext["driver"] = driver;
            Console.WriteLine("Iniciando: " + _scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void ScenarioTearDown()
        {
            driver = (IWebDriver)_scenarioContext["driver"];
            driver.Quit();
        }
    }
}