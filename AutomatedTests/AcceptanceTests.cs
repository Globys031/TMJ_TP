using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
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

        // Tests whether the program can be properly turned
        // on and off
        [Test]
        public void TestTurnOnAndOff()
        {
            desktopSession.FindElementByAccessibilityId("btnCloseForm").Click();
        }

        // Checks if all entries of the movies category
        // are being returned
        [Test]
        public void TestReturnAllEntries()
        {
            desktopSession.FindElementByAccessibilityId("button1").Click();
            List<Entry> entries = DatabaseClass.GetDataByCategory("Movies", "");
            
            NUnit.Framework.Assert.Greater(entries.Count, 0);
        }

        // tests whether it's possible to navigate
        // between the three main categories
        [Test]
        public void TestChangeBetweenCategories()
        {
            desktopSession.FindElementByAccessibilityId("button1").Click();
            desktopSession.FindElementByAccessibilityId("b_TvSeries").Click();
            desktopSession.FindElementByAccessibilityId("button3").Click();
            desktopSession.FindElementByAccessibilityId("button1").Click();
        }

        // When there's too many elements, there should be a scrollbar
        // which allows to properly navigate between elements
        [Test]
        public void TestScrollBar()
        {
            desktopSession.FindElementByAccessibilityId("button1").Click();
            desktopSession.FindElementByAccessibilityId("ScrollbarThumb").Click();
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
        }

        // Removes the entry that was added in "TestInsertEntry"
        [Test]
        public void TestRemoveEntry()
        {
            // AccessibilityId is "Automation ID" on "inspect.exe"
            desktopSession.FindElementByAccessibilityId("b_TvSeries").Click();
            desktopSession.FindElementByAccessibilityId("btnDots0").Click();
            desktopSession.FindElementByAccessibilityId("btnDeleteEntry").Click();
            desktopSession.FindElementByAccessibilityId("btnDeleteEntry").Click();
        }

        // Finds specified entry in the specified category
        [Test]
        public void TestFindEntry()
        {

        }

        // Modifies entry from specified category
        [Test]
        public void TestModifyEntry()
        {

        }

        // Sorts entries from the specified categories by their scores
        [Test]
        public void TestSortEntryScores()
        {

        }

        // Sorts entries from the specified categories by their names
        [Test]
        public void TestSortEntryNames()
        {

        }
    }
}
