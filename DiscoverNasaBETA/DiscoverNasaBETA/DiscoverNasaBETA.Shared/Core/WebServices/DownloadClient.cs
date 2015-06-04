using DiscoverNasaBETA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverNasaBETA.Core.WebServices
{
    class DownloadClient : IDownloadClient
    {
        public async Task<string> DownloadString( Uri uri )
        {
            //throw new NotImplementedException();

            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(uri);
            }

            return null;
        }

        public async Task<string> DownloadString( string uri )
        {
            //throw new NotImplementedException();

            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(uri);
            }

            return null;
        }
    }
}
