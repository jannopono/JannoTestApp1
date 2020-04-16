using NUnit.Framework;
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

        // test cases begin here...
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
        [Test]
        public void TestButtons()
        {
            SetupHooks.App.Tap(c => c.Marked("btnClickMe"));
        }

        [Test]
        public void TestWriteToTextBox()
        {
            string whateverYourText = "Xamarin UI Test";
            SetupHooks.App.EnterText(c => c.Marked("textBox"), whateverYourText);

        }



    }
}
