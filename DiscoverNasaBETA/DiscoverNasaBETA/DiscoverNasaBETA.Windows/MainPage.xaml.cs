﻿using DiscoverNasaBETA.Core.Interfaces;
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
        protected override void OnNavigatedTo( NavigationEventArgs e )
        {
            base.OnNavigatedTo(e);
            dClient=new DownloadClient();
            urlService=new ApiUrlService("https://api.nasa.gov/planetary/apod?");
            var api = urlService.getUrl("concept_tags;api_key;date", "concept_tags;api_key;date");
        }
    }
}
