using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MySelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver("./"))
            {
                driver.Url = "file:///C:/_/projects/rojydesign/dogramaplovdiv.html";
                Screenshot screenshot = driver.GetScreenshot();
                screenshot.SaveAsFile("gg.png");
            }
        }
    }
}
