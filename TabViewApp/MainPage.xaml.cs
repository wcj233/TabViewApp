using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TabViewApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public class MyViewModel
    {
        public string IconUrl { get; set; }
        public string WebUrl { get; set; }
        public string HeaderName { get; set; }
    }

    public sealed partial class MainPage : Page
    {
        private ObservableCollection<MyViewModel> Lists { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            Lists = new ObservableCollection<MyViewModel>();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Lists.Add(new MyViewModel() { WebUrl = "http://www.facebook.com", HeaderName = "Facebook", IconUrl = "https://www.google.com/s2/favicons?domain=https://www.facebook.com/" });

        }
    }
}
