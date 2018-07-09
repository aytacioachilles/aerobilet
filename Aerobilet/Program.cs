using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;


namespace Example3
{
    class Program
    {
        static void Main()
        {

            IWebDriver driver = new ChromeDriver();
            string url = "https://www.aerobilet.com.tr/otel";
            string origin = "hotelName";
            string originDropdown = "searchTerm";


            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            IWebElement element = driver.FindElement(By.Name(origin));

            element.Clear();

            element.SendKeys("Sungate");

            IWebElement dropdownElement = driver.FindElement(By.ClassName(originDropdown));

            //This provides the mouse to bring on top of a specific element
            Actions action = new Actions(driver);
            action.MoveToElement(dropdownElement).Perform();

            dropdownElement.Click();

            //This helps to apply forced timeout before carrying out the operation
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            IWebElement checkIndate = driver.FindElement(By.Name("checkInDate"));

            Actions action2 = new Actions(driver);
            action.MoveToElement(checkIndate).Perform();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);



            checkIndate.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            IWebElement checkOutdate = driver.FindElement(By.Name("checkOutDate"));

            Actions action3 = new Actions(driver);
            action.MoveToElement(checkOutdate).Perform();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            checkOutdate.Click();

            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id=\"hotelSearch\"]/div[4]/div[3]/button"));

            Actions action4 = new Actions(driver);
            action.MoveToElement(searchButton).Perform();

            searchButton.Click();

            /*

            IWebElement mapView = driver.FindElement(By.Id("maplink"));

            IJavaScriptExecutor jsmap = (IJavaScriptExecutor)driver;
            jsmap.ExecuteScript(" ", mapView);

            mapView.Click();


            IWebElement wideMap = driver.FindElement(By.ClassName("wide-map"));

            if (wideMap.Displayed)
            {
                Console.WriteLine("Wide map succesfully displayed!");
            }
            else
            {
                Console.WriteLine("Wide Map link is broken!");
            }

            */

            /*

            IWebElement languageSelection = driver.FindElement(By.Id("languageSelection"));

            int ix = driver.FindElements(By.CssSelector("#languageSelection > " + "*")).Count;



            SelectElement selectLanguage = new SelectElement(languageSelection);
            string text = selectLanguage.SelectedOption.Text;

            Console.WriteLine("Current selected language is {0}", text);
            Console.WriteLine("Total number of languages is {0}", ix-1);

            for (int i = 2; i < ix; i++)
            {
                Console.WriteLine(driver.FindElement(By.CssSelector("#languageSelection > option:nth-child(" + i + ")")).GetAttribute("value") + "-" + driver.FindElement(By.CssSelector("#languageSelection > option:nth-child(" + i + ")")).Text);
            }

           
            */











            /*

            IWebElement newPage = driver.FindElement(By.XPath("//*[@id=\"priceDetailHotelForm\"]/div/div/div[2]/div"));
            

            //this is a code to scroll down to a specific element
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", newPage);


            IWebElement comparison1 = driver.FindElement(By.XPath("//*[@id=\"priceDetailHotelForm\"]/div/div/div[1]/div/div[2]/div[4]/div/div[1]/p/strong"));
            IWebElement comparison2 = driver.FindElement(By.XPath("//*[@id=\"priceDetailHotelForm\"]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/p/strong"));

            string firstString = comparison1.Text;
            string secondString = comparison2.Text;

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);

            char[] firstNumber = firstString.ToCharArray();
            char[] secondNumber = secondString.ToCharArray();

            string firstStringFinal = "";
            string secondStringFinal = "";

            foreach (var item in firstNumber)
            {
                char c = item;
                

                if (Char.IsNumber(c))
                {
                    firstStringFinal = firstStringFinal + item;
                }
            }

            foreach (var item in secondNumber)
            {
                char c = item;
               

                if (Char.IsNumber(c))
                {
                    secondStringFinal = secondStringFinal + item;
                }
            }

            Console.WriteLine(firstStringFinal);
            Console.WriteLine(secondStringFinal);


            int firstPrice = int.Parse(firstStringFinal);
            int secondPrice = int.Parse(secondStringFinal);



            if (secondPrice > firstPrice)
            {
                Console.WriteLine("Test successfull!");
            } else
                {
                Console.WriteLine("Test failed!");
                }

           
           
            */



        }
    }




}



