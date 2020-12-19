using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using TheNewSchoolTesting;

namespace TheNewSchoolTesting
{
    public class TestBase
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars {get; private set;}
        public IJavaScriptExecutor js;
        
        protected ApplicationManager app;
        [SetUp]
        public void SetupTest()
        {
            // app = new ApplicationManager();
            app = ApplicationManager.GetInstance();
        }

        // [TearDown]
        // protected void TearDown() {
        //     app.Stop();
        // }
    }
}