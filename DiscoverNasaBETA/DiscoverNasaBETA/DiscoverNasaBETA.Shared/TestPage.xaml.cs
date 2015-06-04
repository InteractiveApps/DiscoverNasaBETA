using DiscoverNasaBETA.Core.FileSerivces;
using DiscoverNasaBETA.Core.Interfaces;
using DiscoverNasaBETA.Core.WebServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DiscoverNasaBETA
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestPage : Page
    {
        public string downloadData { get; set; }
        public TestPage()
        {
            downloadData=string.Empty;
            this.InitializeComponent();

        }

        private async void downloadCtn_Click( object sender, RoutedEventArgs e )
        {
            try
            {
                IDownloadClient _downloadClient = new DownloadClient();
                downloadData=await _downloadClient.DownloadString(Url_box.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void retrieveBtn_Click( object sender, RoutedEventArgs e )
        {
            try
            {
                IFileRetriever retriever = new FileRetriever();
                var _file = await retriever.GetFile(FileName.Text);

                using (var _stream = await _file.OpenStreamForReadAsync())
                    using(var _reader = new StreamReader(_stream))
                {
                    resultBox.Text =  await  _reader.ReadToEndAsync();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async void saveDownload_Click( object sender, RoutedEventArgs e )
        {
            try
            {
                IFileSaver saver = new FileSaver();
                if (await saver.SaveFile(FileName.Text, downloadData))
                {
                    status.Foreground=new SolidColorBrush(Colors.SkyBlue);
                    status.Text="save succesful!";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
