using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DiscoverNasaBETA.Core.Interfaces;
using Windows.Storage;
using System.IO;

namespace DiscoverNasaBETA.Core.FileSerivces
{
    class FileRetriever : IFileRetriever
    {
        public async Task<StorageFile> GetFile( string fileName )
        {
            // throw new NotImplementedException();
            var _folder = ApplicationData.Current.LocalFolder;
            try
            {
              var _file = await _folder.GetFileAsync(fileName);
                return _file;
            }
            catch (FileNotFoundException)
            {
                //notify user about the excption.
            }

               
            return null;
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
