using DiscoverNasaBETA.Core.Interfaces;
using DiscoverNasaBETA.Core.WebServices;
using System;
using System.Collections.Generic;
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
using DiscoverNasaBETA.Core.ApiServices;
using DiscoverNasaBETA.Core.NasaApis;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DiscoverNasaBETA
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        IDownloadClient dClient { get; set; }
        ApiUrlService urlService { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override async void OnNavigatedTo( NavigationEventArgs e )
        {
            base.OnNavigatedTo(e);

            dClient=new DownloadClient();

            ApodUrlGenerator apod_url_gen = new ApodUrlGenerator();
            var url = apod_url_gen.GetUrl();

            string json = await dClient.DownloadString(url);
            
                          

        }
    }

    public class Apod_RootObject
    {
        public string url { get; set; }
        public string media_type { get; set; }
        public string explanation { get; set; }
        public List<object> concepts { get; set; }
        public string title { get; set; }
    }
}
