
using OpenQA.Selenium;

namespace CookieClicker_Automation
{
   public class TestBase
    {
        public IWebDriver driver;
        public BasePage basePage;
        public LandingPage landingPage;
        public StartPage startPage;

        public TestBase()
        {
            driver = DriverClass.CreateDriver();
            basePage = new BasePage(driver);
            landingPage = new LandingPage(driver);
            startPage = new StartPage(driver);
        }

        public void LaunchCoockieClickerApplication()
        {
            //driver.Navigate().GoToUrl("https://www.google.com/");
            //AcceptAllButton();
            driver.Navigate().GoToUrl("Gajanan-bogam-2023-04-25.cookieclickertechtest.airelogic.com");
        }

        public void AcceptAllButton()
        {
            basePage.AcceptAllButton.Click();
        }

        public void StartTheGameByEnteringPlayerName()
        {
            landingPage.YourNameTextInputBox.SendKeys(Constants.Player1Name);
            landingPage.StartButton.Click();
        }

        public void CollectCookies(int noOfCookies)
        {
            for (int i = 1; i == noOfCookies; i++)
            {
                startPage.ClickCookieButton.Click();
            }
        }

        public void SellCookies(string cookies)
        {
            startPage.SellCookiesInputBox.SendKeys(cookies);
            startPage.SellCookiesButton.Click();
        }

        public void BuyFactories(string noOfFactories )
        {
            startPage.BuyFactoriesInputBox.SendKeys(noOfFactories);
            startPage.BuyFactoriesButton.Click();
        }

        public void Dispose()
        {
            driver.Dispose();
        }

    }
}
