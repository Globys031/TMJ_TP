using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;

//Uses NUnit type tests and WinAppDriver
namespace AutomatedTests
{
    /*
     * Before doing AutomatedTests -> Run tests, always have this turned on:
     * C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe
     * Otherwise nothing will run.
     * Also, this one is useful for finding things like which button is being pressed
     * C:\Program Files (x86)\Windows Kits\10\bin\10.0.19041.0\x64\inspect.exe
     * Most of this can be found under our discord in "important" text channel
     */
    [TestFixture]
    public class AcceptanceTests
    {
        private WindowsDriver<WindowsElement> customListSession;
        private WindowsDriver<WindowsElement> desktopSession;

        [SetUp]
        public void TestInitialize()
        {
            var options = new AppiumOptions();
            // Change the path based on where your CustomList\bin\Debug\CustomList.exe is located
            options.AddAdditionalCapability("app", @"C:\Users\justi\Desktop\TMJ_TP\TMJ_TP\CustomList\bin\Debug\CustomList.exe");
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            customListSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            customListSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            options = new AppiumOptions();
            options.AddAdditionalCapability("app", "Root");
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            desktopSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            desktopSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void TestCleanup()
        {
            if (customListSession != null)
            {
                customListSession.Quit();
                customListSession = null;
            }
        }

        // Method won't work if there's too many entries in category
        // (That's because WinAppDriver is unable to see the "add" button
        [Test]
        public void TestInsertEntry()
        {
            // AccessibilityId is "Automation ID" on "inspect.exe"
            desktopSession.FindElementByAccessibilityId("b_TvSeries").Click();
            desktopSession.FindElementByAccessibilityId("btnAddEntry").Click();
            // Element name would be when you go to the bottom of desktop
            // and hover over an app window
            desktopSession.FindElementByName("AddEntryDialogueForm");
            desktopSession.FindElementByAccessibilityId("txtEntryName").SendKeys("coolEntryName");
            desktopSession.FindElementByAccessibilityId("txtRating").SendKeys("8");
            desktopSession.FindElementByAccessibilityId("btnSave").Click();
            // Later (after testing that "getEntry" actually works) add
            // an assert statement to see that the entry actually got saved
            // also after testing that delete works, add delete because
            // right now there's multiple entries.
        }

    }
}
