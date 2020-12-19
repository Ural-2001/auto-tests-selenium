using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TheNewSchoolTesting
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;
        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }
        
        public void OpenBlogPage()
        {
            driver.FindElement(By.LinkText("Блог iHerb")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".featured-article > a"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void OpenPartnersPage()
        {
            driver.FindElement(By.LinkText("Партнеры-поставщики")).Click();
            {
                var element = driver.FindElement(By.LinkText("Партнеры-поставщики"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
        }

        public void Scroll()
        {
            js.ExecuteScript("window.scrollTo(0,33)");
            js.ExecuteScript("window.scrollTo(0,300)");
            js.ExecuteScript("window.scrollTo(0,860)");
            js.ExecuteScript("window.scrollTo(0,1674)");
            js.ExecuteScript("window.scrollTo(0,2403)");
            js.ExecuteScript("window.scrollTo(0,3300)");
        }

        public void OpenAboutPage()
        {
            driver.FindElement(By.LinkText("О нас")).Click();
        }
        
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://ru.iherb.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1627, 1027);
        }
    }
}