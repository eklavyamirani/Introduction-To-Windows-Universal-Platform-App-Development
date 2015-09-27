using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Demo_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeviceSpecificCodeExample : Page
    {
        public DeviceSpecificCodeExample()
        {
            this.InitializeComponent();
            var hardwareButtonViewModel = new HardwareButtonViewModel();
            this.DataContext = hardwareButtonViewModel;

            if (hardwareButtonViewModel.IsCameraButtonPresent)
            {
                Windows.Phone.UI.Input.HardwareButtons.CameraPressed += HardwareButtons_CameraPressed;
            }
            else
            {
                this.SoftCameraButton.Click += SoftCameraButton_Click;
            }
            
        }

        private void SoftCameraButton_Click(object sender, RoutedEventArgs e)
        {
            ShowCameraDialog();
        }

        private void HardwareButtons_CameraPressed(object sender, Windows.Phone.UI.Input.CameraEventArgs e)
        {
            ShowCameraDialog();
        }

        private async void ShowCameraDialog()
        {
            var dialog = new MessageDialog("Camera button was pressed", "Camera Hardware Button");
            await dialog.ShowAsync();
        }
    }

    public class HardwareButtonViewModel
    {
        public bool IsCameraButtonPresent { get; set; }

        public HardwareButtonViewModel()
        {
            this.IsCameraButtonPresent =
                Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons");
        }
    }
}
