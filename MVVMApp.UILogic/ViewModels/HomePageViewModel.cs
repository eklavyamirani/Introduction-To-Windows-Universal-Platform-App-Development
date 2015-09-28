using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Windows.UI.Xaml.Navigation;

namespace MVVMApp.UILogic.ViewModels
{
    public class HomePageViewModel : ViewModel
    {
        private string title;

        public string Title
        {
            get { return this.title; }
            set { this.SetProperty(ref this.title, value); }
        }

        public HomePageViewModel()
        {
            
        }

        public override void OnNavigatedTo(object navigationParameter, NavigationMode navigationMode, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(navigationParameter, navigationMode, viewModelState);
            this.Title = "Welcome to MVVM App!";
        }
    }
}
