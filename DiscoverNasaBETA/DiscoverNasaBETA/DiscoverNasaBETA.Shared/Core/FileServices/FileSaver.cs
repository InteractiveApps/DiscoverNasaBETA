using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DiscoverNasaBETA.Core.Interfaces;
using Windows.Storage;

namespace DiscoverNasaBETA.Core.FileSerivces
{
    class FileSaver : IFileSaver
    {
        public async Task<bool> SaveFile( string fileName, string data )
        {
            var _folder = ApplicationData.Current.LocalFolder;
            try
            {

                var _file = await _folder.CreateFileAsync(fileName , CreationCollisionOption.ReplaceExisting);
                using(var _stream = await _file.OpenStreamForWriteAsync())
                using (StreamWriter _writer = new StreamWriter(_stream))
                {
                    await _writer.WriteAsync(data);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            return false;
        }

        public bool SaveFile( Uri uri, StorageFolder folder, string data )
        {
            throw new NotImplementedException();
        }

        public bool SaveFile( Uri uri, string fileName, string data )
        {
            throw new NotImplementedException();
        }

        public bool SaveFile( string uri, StorageFolder folder, string data )
        {
            throw new NotImplementedException();
        }

        public bool SaveFile( string uri, string fileName, string data )
        {
            throw new NotImplementedException();
        }
    }
}
