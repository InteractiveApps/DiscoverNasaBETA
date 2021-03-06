﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace DiscoverNasaBETA.Core.Interfaces
{
    interface IFileRetriever
    {
        Task<StorageFile> GetFile( string fileName );

        StorageFile GetFile( string uri, string fileName );

        StorageFile GetFile( string uri, StorageFolder folder );

        StorageFile GetFile( Uri uri, string fileName );

        StorageFile GetFile( Uri uri, StorageFolder folder );
    }
}
