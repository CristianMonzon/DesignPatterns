namespace Iterator
{
    public interface IMensajeIterator<T>
    {
        bool HasNext();
        T Next();
    }

    public interface IMensajeColeccion<T>
    {
        IMensajeIterator<T> CrearIterador();
    }

    public interface IMensajeDeBienvenida
    {
        string GetMessage();
    }
}