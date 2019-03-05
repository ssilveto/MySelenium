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
            string url = "https://google.com";


            using (var driver = new ChromeDriver(currentDir))
            {
                driver.Url = url;

                Screenshot myScreenshot = driver.GetScreenshot();
                myScreenshot.SaveAsFile($"ss-{DateTime.UtcNow.ToString("yyyyMMdd-hhmmss-fff")}.png");
            }
        }
    }
}
