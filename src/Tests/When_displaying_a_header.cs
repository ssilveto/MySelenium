using Machine.Specifications;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Tests
{
    public class When_displaying_a_header
    {
        Because of = () =>
        {
            const string currentDir = "./";
            string url = "file:///C:/_/projects/rojydesign/dogramaplovdiv.html";

            using (ChromeDriver driver = new ChromeDriver(currentDir))
            {
                driver.Url = url;
                IWebElement rojyLink = driver.FindElementByTagName("a");

                rojyLinkExtracted = rojyLink.GetAttribute("href");

                IWebElement rojyImage = driver.FindElementByTagName("img");

                extractedSrcValue = rojyImage.GetAttribute("src");

            }

        };

        It should_have_a_rojy_logo_image = () => extractedSrcValue.ShouldEqual(expectedSrcValue);
        It should_have_a_redirect_link_to_rojy_website = () => rojyLinkExtracted.ShouldEqual(rojyLinkExpected);

        static string rojyLinkExtracted;
        static string rojyLinkExpected = "http://rojy.design/";
        static string extractedSrcValue;
        static string expectedSrcValue = "http://rojy.design/wp-content/uploads/2017/01/rojy-logo-1.png";
    }
}
