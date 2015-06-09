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
using Newtonsoft.Json;
using DiscoverNasaBETA.Models;
using System.Threading.Tasks;

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
            var url = apod_url_gen.GetDefaultUrl();

            string json = await  dClient.DownloadString(url);
            Apod_RootObject root = JsonConvert.DeserializeObject<Apod_RootObject>(json);

            ApiUrlService ser = new ApiUrlService("https://api.nasa.gov/planetary/earth/imagery?");
            var uri = ser.GetUrl("lat;lon;cloud_source;api_key", "10.0;10.0;false;I3pA7RdSKvrER6hm6f51BhWzCmoJM6Alq6BjbbEu");
            json = await dClient.DownloadString(uri);
            
            apodHubSection.DataContext=root;
            imagerSection.DataContext=JsonConvert.DeserializeObject<Imagery_RootObject>(json);
        }
    }



}
