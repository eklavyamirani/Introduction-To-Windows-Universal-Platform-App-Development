using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Demo_App
{
    public partial class MainPage : Page
    {
        public List<Scenario> Scenarios = new List<Scenario>()
        {
            new Scenario() { Title = "Device Specific Code", Page = typeof(DeviceSpecificCodeExample) }
        };
    }

    public class Scenario
    {
        public string Title { get; set; }

        public Type Page { get; set; }
    }
}
