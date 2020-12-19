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
    public class HelperBase
    {
        public IJavaScriptExecutor js;
        protected IWebDriver driver;
        protected bool acceptNextAlert = true;
        protected ApplicationManager manager;
        
        public HelperBase(ApplicationManager manager)
        {
            js = (IJavaScriptExecutor) driver;
            this.manager = manager;
            this.driver = manager.Driver;
        }
    }
}