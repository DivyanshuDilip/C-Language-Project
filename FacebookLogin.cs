using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject;

namespace CSharpPrograms
{
    class FacebookLogin
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.facebook.com/");

            LoginFile logInData = new LoginFile();

            logInData.LoginFunction(driver, "divyanshujain61@yahoo.com", "8793220162");


        }
    }
}