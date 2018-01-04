using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Framework.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "https://www.alitalia.com/en_en";

        [FindsBy(How = How.Id, Using = "departureInput")]
        private IWebElement departureInput;

        [FindsBy(How = How.Id, Using = "arrivalInput")]
        private IWebElement arrivalInput;

        [FindsBy(How = How.Id, Using = "andata")]
        private IWebElement andata;

        [FindsBy(How = How.Id, Using = "ritorno")]
        private IWebElement ritorno;
       
        [FindsBy(How = How.XPath, Using = "//*[@id=\"cercaVoliForm\"]/div/fieldset[4]/ol/li[1]/div/a[1]")]
        private IWebElement buttonAdult;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cercaVoliForm\"]/div/fieldset[4]/ol/li[1]/div/a[2]")]
        private IWebElement buttonAdultMinus;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cercaVoliForm\"]/div/fieldset[4]/ol/li[2]/div/a[1]")]
        private IWebElement buttonChildren;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cercaVoliForm\"]/div/fieldset[4]/ol/li[3]/div/a[1]")]
        private IWebElement buttontInfant;

        [FindsBy(How = How.Id, Using = "cercaVoliSubmit")]
        private IWebElement SearchButton;

        

        


        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ClickButton()
        {
            SearchButton.Click();
        }



        public void Test1(string origin, string destination, DateTime departDate, DateTime returnDate)
        {
            departureInput.SendKeys(origin);
            departureInput.SendKeys(Keys.Enter);
            arrivalInput.SendKeys(destination);
            arrivalInput.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            andata.SendKeys(Convert.ToString(departDate));
            andata.SendKeys(Keys.Enter);
            ritorno.SendKeys(Convert.ToString(returnDate));
            ritorno.SendKeys(Keys.Tab);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            buttonAdult.Click();
            SearchButton.Click();
        }

        public void Test2(string origin, string destination, DateTime departDate, DateTime returnDate)
        {
            departureInput.SendKeys(origin);
            departureInput.SendKeys(Keys.Enter);
            arrivalInput.SendKeys(destination);
            arrivalInput.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            andata.SendKeys(Convert.ToString(departDate));
            andata.SendKeys(Keys.Enter);
            ritorno.SendKeys(Convert.ToString(returnDate));
            ritorno.SendKeys(Keys.Tab);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            buttonAdult.Click();
            buttonChildren.Click();
            buttontInfant.Click();
            SearchButton.Click();
        }

        public void Test3(string origin, DateTime departDate, DateTime returnDate)
        {
            departureInput.SendKeys(origin);
            departureInput.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            andata.SendKeys(Convert.ToString(departDate));
            andata.SendKeys(Keys.Enter);
            ritorno.SendKeys(Convert.ToString(returnDate));
            ritorno.SendKeys(Keys.Tab);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            buttonAdult.Click();
            SearchButton.Click();
        }

        public void Test4(string origin, string destination, DateTime departDate, DateTime returnDate, DateTime returnDate1)
        {
            departureInput.SendKeys(origin);
            departureInput.SendKeys(Keys.Enter);
            arrivalInput.SendKeys(destination);
            arrivalInput.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            andata.SendKeys(Convert.ToString(departDate));
            andata.SendKeys(Keys.Enter);
            ritorno.SendKeys(Convert.ToString(returnDate));
            ritorno.SendKeys(Keys.Tab);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            buttonAdult.Click();
            ritorno.Clear();
            ritorno.SendKeys(Convert.ToString(returnDate1));
            ritorno.SendKeys(Keys.Tab);
            buttonAdultMinus.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            SearchButton.Click();
        }

        public void Test5(string origin, DateTime departDate, DateTime returnDate)
        {
            departureInput.Clear();
            departureInput.SendKeys(Keys.Enter);
            arrivalInput.SendKeys(origin);
            arrivalInput.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            andata.SendKeys(Convert.ToString(departDate));
            andata.SendKeys(Keys.Enter);
            ritorno.SendKeys(Convert.ToString(returnDate));
            ritorno.SendKeys(Keys.Tab);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            buttonAdult.Click();
            SearchButton.Click();
        }

        public bool IsTicketsListExist()
        {
            var ticketsList = driver.FindElements(By.XPath("//*[@id=\"booking - flight - select - selection\"]/div[10]/div[3]/div[1]"));
            return ticketsList.Count > 0 ? true : false;
        }

        public bool IsErrorExist()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return null != driver.FindElement(By.XPath("//*[@id=\"booking - flight - select - selection\"]/div[10]/div")) ? true : false;
                                                        
        }

        public bool IsErrorDestination()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return null != driver.FindElement(By.Id("Destination_error")) ? true : false;

        }

        public bool IsErrorOrigin()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return null != driver.FindElement(By.Id("Origin_error")) ? true : false;

        }

        public bool IsErrorData()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return null != driver.FindElement(By.Id("ReturnDate_error")) ? true : false;

        }

    }



}

