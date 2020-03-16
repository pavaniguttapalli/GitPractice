using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace GitHub_Jenkins
{
    public class Class1
    {
        public IWebDriver driver;   
        public void Method1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=accountsettings&continue=https%3A%2F%2Fmyaccount.google.com%2Femail&gmb=exp&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";
        }
    }
}
