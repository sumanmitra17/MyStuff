using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestApplication
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {

            IWebDriver dr = new ChromeDriver(@"E:\Suman\Softwares\Cell\Visual Studio\Driver");
            dr.Manage().Window.Maximize();
            dr.Url = "http://172.17.3.13/site/login";
            String s = dr.Title;
            dr.FindElement(By.XPath("//*[@id='lst-ib']")).SendKeys("Sachin");
            Console.WriteLine(s);
            dr.FindElement(By.Name("username")).SendKeys("_T_Admin");
            dr.FindElement(By.Name("password")).SendKeys("$123#LordTest");
            dr.FindElement(By.XPath("//*[@id='login-form']/button")).Click();
        }
    }
}
