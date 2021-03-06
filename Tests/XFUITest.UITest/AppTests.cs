﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XFUITest.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class AppTests
    {
        public AppTests(Platform platform)
        {
            SetupHooks.Platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            SetupHooks.App =
            AppInitializer.StartApp(SetupHooks.Platform, true);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] homePageExists = SetupHooks.App.WaitForElement(c => c.Marked("MainPage"));
            Assert.IsTrue(homePageExists.Any());

            //AppResult[] welcomeLabelExists = SetupHooks.App.WaitForElement(c => c.Marked("lblWelcome"));
            //Assert.IsTrue(welcomeLabelExists.Any());

            //welcomeLabelExists = SetupHooks.App.WaitForElement(c => c.Text("Hey there, Welcome!"));
            //SetupHooks.App.Screenshot("Welcome Screen");
            
        }

	// test cases begin here...
		
	}
}
