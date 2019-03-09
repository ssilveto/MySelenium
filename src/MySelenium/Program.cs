using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace MySelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            const string currentDir = "./";
            string url = "file:///C:/_/projects/rojydesign/dogramaplovdiv.html";

            using (ChromeDriver driver = new ChromeDriver(currentDir))
            {
                driver.Url = url;
                IWebElement rojyLink = driver.FindElementByTagName("a");
                string rojyLinkExtracted = rojyLink.GetAttribute("href");
                string rojyLinkExpected = "http://rojy.design/";
                if (rojyLinkExtracted == rojyLinkExpected)
                {
                    Console.WriteLine("Link");
                }


                IWebElement rojyImage = driver.FindElementByTagName("img");

                string extractedSrcValue = rojyImage.GetAttribute("src");
                string expectedSrcValue = "http://rojy.design/wp-content/uploads/2017/01/rojy-logo-1.png";
                if (rojyImage.Displayed && rojyImage.Enabled && expectedSrcValue == extractedSrcValue)
                {
                    Console.WriteLine("Tam e");
                }

                IWebElement telephoneNumber = driver.FindElementById("contactNumber");
                string extractedTelephoneNumber = telephoneNumber.Text;
                string expectedTelephoneNumber = "+359 896 222 575";
                if (extractedTelephoneNumber == expectedTelephoneNumber)
                {
                    Console.WriteLine("Telephone Number");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
        }

        static bool RojyImageExists(int f, int sec)
        {
            return true;
        }
    }
}
