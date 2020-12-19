using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using TheNewSchoolTesting;

[TestFixture]
public class Iherb123Test : TestBase {
  AccountData user = new AccountData("ural.rainur@gmail.com", "Iherb-Super");
  [Test]
  public void iherb123() {
    app.Navigation.OpenHomePage();
    app.Login.Login(user);
    // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    app.Navigation.OpenAboutPage();
    // app.Navigation.Scroll();
    app.Navigation.OpenPartnersPage();
    app.Navigation.OpenBlogPage();
    
  }

  [Test]
  public void iherb2()
  {
    app.Navigation.OpenHomePage();
    app.Login.Login(user);
    app.Navigation.OpenBlogPage();
  }
}
