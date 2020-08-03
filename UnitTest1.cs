using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace Wooza
{
    public class Tests
    {
        String test_url = "https://www.celulardireto.com.br/";

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();

            
        }

        [Test]
        public void Test1()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Url = test_url;

            System.Threading.Thread.Sleep(7000);

            driver.FindElement(By.XPath("//*[@id='menu-header-1']/li[1]/a")).Click();

            System.Threading.Thread.Sleep(7000);

            //TIM
            driver.FindElement(By.XPath("//*[@id='field-group-operatorCode41']/span")).Click();

            System.Threading.Thread.Sleep(7000);

            js.ExecuteScript("window.scrollBy(0,300)");

            System.Threading.Thread.Sleep(7000);

            //TIM Controle
            driver.FindElement(By.XPath("//*[@id='field-group-planType1']/span")).Click();

            System.Threading.Thread.Sleep(7000);
            
            //Mais de 5.0 GB
            driver.FindElement(By.XPath("//*[@id='field-group-dataValue5.1_null']/span")).Click();
            
            System.Threading.Thread.Sleep(7000);

            //De R$ 39,99 a R$ 54,99.
            driver.FindElement(By.XPath("//*[@id='field-group-planValue39_55']/span")).Click();
            
            System.Threading.Thread.Sleep(7000);

        }

        [TearDown]
        public void Fechar()
        {
            driver.Quit();
        }

    }
}

   