namespace Facade
{
    public interface IMensajeDeBienvenida
    {
        string GetMessage();
    }

    public interface IMensajeDeBienvenidaFacade : IMensajeDeBienvenida
    {
        string Usuario { get; }
        DateTime Fecha { get; }
        string Texto { get; }
        int Importancia { get; }        
    }
}