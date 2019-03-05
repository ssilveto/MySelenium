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

            using (var driver = new ChromeDriver(currentDir))
            {
                driver.Url = url;

                string pageSource = driver.PageSource;
                File.WriteAllText("source.html", pageSource);

                Screenshot myScreenshot = driver.GetScreenshot();
                myScreenshot.SaveAsFile($"ss-{DateTime.UtcNow.ToString("yyyyMMdd-hhmmss-fff")}.png");
            }
        }
    }
}
