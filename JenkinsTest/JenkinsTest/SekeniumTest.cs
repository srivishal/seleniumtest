using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Data;


namespace JenkinsTest
{
    public class SekeniumTest
    {
        public IWebDriver driver;
        private string Chrome_Driver = @Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\chromedriver";
        public static string browser = System.Environment.GetEnvironmentVariable("Browser");
        public static string pageUrl = System.Environment.GetEnvironmentVariable("Page");

        //public static string browser = "chrome";
        //public static string pageUrl = "www.yahoo.com";
        public IWebDriver getDriver(string browserType)
        {
            switch (browserType.ToLower())
            
            {
                case "chrome":
                     var options = new ChromeOptions();
                            driver = new ChromeDriver(Chrome_Driver);
                    break;
                case "firefox" :
                    driver = new FirefoxDriver();
                    break;
                case "default":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
                    
            }
            return driver;
        }

        [Test]
        public void OpenGooglePage()
        {
            driver = getDriver(browser);
            Console.WriteLine("testing");
            driver.Navigate().GoToUrl(pageUrl);
            driver.Quit();
        }

      
        //[Test]
        //public void OpenYahooPage()
        //{
        //    driver = getDriver(browser);
        //    driver.Navigate().GoToUrl("www.yahoo.com");
        //}
 
    }
}
