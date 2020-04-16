using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XFUITest.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform, true);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] homePageExists = app.WaitForElement(c => c.Marked("MainPage"));
            Assert.IsTrue(homePageExists.Any());
        }

        //public void TestButton()
        //{
        //    AppResult[] btn = SetupHooks.App.WaitForElement(c => c.Marked("btnClickMe"));
        //    Assert.IsTrue(btn.Any());
        //}
    }
}
