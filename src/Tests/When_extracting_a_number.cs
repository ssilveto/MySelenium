using Machine.Specifications;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Tests
{
    public class When_extracting_a_number
    {
        Because of = () => extractedValue = 8;

        It should_have_the_correct_value = () => extractedValue.ShouldEqual(expectedValue);

        static int extractedValue;
        static int expectedValue = 7;
    }
}
