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
    public class ApplicationManager
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        public IJavaScriptExecutor js;
        // private StringBuilder verificationErrors;
        private string baseURL;
        private NavigationHelper navigation;
        private LoginHelper auth;
        
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();
        
        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigation.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        private ApplicationManager()
        {
            driver = new ChromeDriver(@"/Users/uralozbaan/Downloads/");
            driver.Manage().Window.Maximize();
            baseURL = "http://localhost";
            // verificationErrors = new StringBuilder();
            js = (IJavaScriptExecutor) driver;
            vars = new Dictionary<string, object>();
            auth = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
        }
        
        public void Stop()
        {
            driver.Quit();
        }

        public IWebDriver Driver
        {
            get { return driver; }
        }

        public NavigationHelper Navigation
        {
            get { return navigation; }
        }

        public LoginHelper Login
        {
            get { return auth; }
        }
        
        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            { 
                //ignore
            }
        }
    }
}