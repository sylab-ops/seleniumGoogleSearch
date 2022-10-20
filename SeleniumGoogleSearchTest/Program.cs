using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGoogleSearchTest
{
    class Program
    {
      
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C://Users//ismes//source//repos//SeleniumGoogleTest//SeleniumGoogleTest//chromedriver");
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("L2AGLb")).Click();
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("Learn Automation");
        }
    }
}
