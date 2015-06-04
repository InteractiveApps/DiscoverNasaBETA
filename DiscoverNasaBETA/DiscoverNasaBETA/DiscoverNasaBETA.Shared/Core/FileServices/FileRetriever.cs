using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DiscoverNasaBETA.Core.Interfaces;
using Windows.Storage;

namespace DiscoverNasaBETA.Core.FileSerivces
{
    class FileRetriever : IFileRetriever
    {
        public async Task<StorageFile> GetFile( string fileName )
        {
            // throw new NotImplementedException();
            var _folder = ApplicationData.Current.LocalFolder;
            var _file = await _folder.GetFileAsync(fileName);
               
            return _file;
        }

        public StorageFile GetFile( Uri uri, StorageFolder folder )
        {
            throw new NotImplementedException();
        }

        public StorageFile GetFile( Uri uri, string fileName )
        {
            throw new NotImplementedException();
        }

        public StorageFile GetFile( string uri, StorageFolder folder )
        {
            throw new NotImplementedException();
        }

        public StorageFile GetFile( string uri, string fileName )
        {
            throw new NotImplementedException();
        }
    }
}
