using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Firefox;

using System.Diagnostics;
using OpenQA.Selenium.Chrome;


namespace Framework.CromeDriver
{
    public class DriverInstance
    {

        private static IWebDriver driver;

        private DriverInstance() { }

        public static IWebDriver GetInstance()
        {
            //try
            //{
            //    driver = new ChromeDriver(@"D:\4 course\epam\geckoandchrome");
            //}
            //catch (Exception e)
            //{
            //    e.StackTrace.ToString();
            //    throw;
            //}
            if (driver == null)
            {

                //Environment.SetEnvironmentVariable("webdriver.gecko.driver", "D:\\4 course\\epam\\geckodriver.exe");
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;

            foreach (var process in Process.GetProcessesByName("geckodriver"))
            {
                process.Kill();
            }
        }
    }
}
