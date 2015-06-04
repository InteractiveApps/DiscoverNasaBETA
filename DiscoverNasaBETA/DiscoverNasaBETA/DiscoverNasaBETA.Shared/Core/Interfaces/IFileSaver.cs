using System;
using Windows.Storage;

namespace DiscoverNasaBETA.Core.Interfaces
{
    interface IFileSaver
    {
        bool SaveFile( string fileName, string data );

        bool SaveFile( string uri, string fileName, string data );

        bool SaveFile( string uri, StorageFolder folder, string data );

        bool SaveFile( Uri uri, string fileName, string data );

        bool SaveFile( Uri uri, StorageFolder folder, string data );
    }
}
