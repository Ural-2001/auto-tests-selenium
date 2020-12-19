using System;
using OpenQA.Selenium;

namespace TheNewSchoolTesting
{
    public class LoginHelper : HelperBase
    {
        public void Login(AccountData user)
        {
            driver.FindElement(By.CssSelector(".icon-header_signed-out")).Click();
            driver.FindElement(By.Id("username_input")).Click();
            driver.FindElement(By.Id("username_input")).SendKeys(user.Username);
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys(user.Password);
            driver.FindElement(By.Id("sign_in_button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // js.ExecuteScript("window.scrollTo(0,1845)");
        }

        public LoginHelper(ApplicationManager manager) : base(manager)
        {

        }

    }
}