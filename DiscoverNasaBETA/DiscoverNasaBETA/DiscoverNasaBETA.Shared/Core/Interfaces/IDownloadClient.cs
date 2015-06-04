using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverNasaBETA.Core.Interfaces
{
    interface IDownloadClient
    {
        Task<string> DownloadString( string uri );
        Task<string> DownloadString( Uri uri ); 
    }
}
