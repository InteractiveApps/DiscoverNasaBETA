namespace DiscoverNasaBETA.Core.Interfaces
{
    interface IJsonSerializer
    {
        string Serailize<T>( T instance );
    }
}
