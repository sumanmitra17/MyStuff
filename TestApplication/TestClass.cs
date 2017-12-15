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
            dr.Url = "https://www.google.com/";
            String s = dr.Title;
            dr.FindElement(By.XPath("//*[@id='lst-i']")).SendKeys("Sachin");
            Console.WriteLine(s);
        }
    }
}
