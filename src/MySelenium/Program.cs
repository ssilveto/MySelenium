using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MySelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            const string currentDir = "./";
            using (var driver = new ChromeDriver(currentDir))
            {
                driver.Url = "https://www.google.com";

                Screenshot myScreenshot = driver.GetScreenshot();
                myScreenshot.SaveAsFile("image.png");
            }
        }
    }
}
