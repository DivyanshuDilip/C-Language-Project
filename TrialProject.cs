using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpPrograms
{
    class TrialProject
    {
        static void Main(string[] args)
        {

            // Initialize ChromeDriver with the options
            IWebDriver driver = new ChromeDriver();

            // Navigate to the website
            driver.Navigate().GoToUrl("https://www.flipkart.com");
            driver.Manage().Window.Maximize();


            IWebElement searchInput = driver.FindElement(By.XPath("//input[@title='Search for Products, Brands and More']"));

            searchInput.SendKeys("Mobile");
            searchInput.SendKeys(Keys.Enter);
            //  Thread.Sleep(2000);
            // searchInput.Click();

            // // Storing Multiple Elements So For That We Are Using List
            IList<IWebElement> mobileOption = driver.FindElements(By.XPath("//div[@class='KzDlHZ']"));

            foreach (var option in mobileOption)
            {
                string allOptions = option.Text;
                Console.WriteLine(option.Text);  // Prints the text inside each <li> element

                if (allOptions == "Motorola g45 5G (Pink Lavender, 128 GB)")
                {
                    option.Click();
                }
            }

            var allWindowHandle = driver.WindowHandles;

            driver.SwitchTo().Window(allWindowHandle[1]);

            IWebElement buyNowButton = driver.FindElement(By.XPath("//button[text()='Buy Now']"));

            buyNowButton.Click();

            Thread.Sleep(3000);
            var actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            IWebElement logInput = driver.FindElement(By.XPath("//input[@type='text']"));

            logInput.Click();
            logInput.SendKeys("8793220162");

            IWebElement continueButton = driver.FindElement(By.XPath("//button[@type='submit']"));

            continueButton.Click();


            Thread.Sleep(Timeout.Infinite);
            // Close the browser
            driver.Quit();
        }
    }
}