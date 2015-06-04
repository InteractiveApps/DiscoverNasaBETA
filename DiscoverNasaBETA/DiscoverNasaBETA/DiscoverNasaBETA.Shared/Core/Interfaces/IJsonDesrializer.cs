namespace DiscoverNasaBETA.Core.Interfaces
{
    interface IJsonDesrializer
    {
        T ConvertTo<T>( string JsonData );
    }
}
