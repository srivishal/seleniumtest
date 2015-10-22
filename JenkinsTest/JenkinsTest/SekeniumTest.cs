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
        IWebDriver driver;
        private string Chrome_Driver = @Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\chromedriver";
        public static string browser = System.Environment.GetEnvironmentVariable("Browser");
        public static string pageUrl = System.Environment.GetEnvironmentVariable("Page");
        public IWebDriver getDriver(string browserType)
        {
            switch (browserType.ToLower())
            {
                   
                case "chromes":
                     var options = new ChromeOptions();
                            driver = new ChromeDriver(Chrome_Driver);
                    break;
                case "firefox" :
                    driver = new FirefoxDriver();
                    break;
                case "default":
                    driver = new FirefoxDriver();
                    break;
                    lwnlklsd
            }
            return driver;
        }

        [Test]
        public void OpenGooglePage()
        {
            driver = getDriver(browser);
            driver.Navigate().GoToUrl(pageUrl);
        }
        [Test]
        public void OpenYahooPage()
        {
            driver = getDriver(browser);
            driver.Navigate().GoToUrl("www.yahoo.com");
        }
 
    }
}
