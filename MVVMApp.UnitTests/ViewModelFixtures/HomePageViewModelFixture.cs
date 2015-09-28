using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using MVVMApp.UILogic.ViewModels;

namespace MVVMApp.UnitTests.ViewModelFixtures
{
    [TestClass]
    public class HomePageViewModelFixture
    {
        private HomePageViewModel homePageViewModel;

        [TestInitialize]
        public void TestSetup()
        {
            homePageViewModel = new HomePageViewModel();
        }

        [TestMethod]
        public void OnNavigatedToHomePage_Should_Set_The_Title()
        {
            // Pre conditions
            Assert.IsTrue(string.IsNullOrEmpty(this.homePageViewModel.Title));

            // Action
            this.homePageViewModel.OnNavigatedTo(null, Windows.UI.Xaml.Navigation.NavigationMode.New, new Dictionary<string, object>());

            // Validate
            Assert.IsFalse(string.IsNullOrEmpty(this.homePageViewModel.Title));
        }
    }
}
