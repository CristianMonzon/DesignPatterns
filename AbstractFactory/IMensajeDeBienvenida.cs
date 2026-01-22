namespace AbstractFactory
{
    public interface IUsuarioFactory 
    {
        IMensajeDeBienvenida CrearMensajeBienvenida();
        IMensajeDespedida CrearMensajeDespedida(); 
        IMensajeError CrearMensajeError(); 
    }

    public interface IMensajeDeBienvenida
    {
        string GetMessage();
    }

    public interface IMensajeDespedida
    {
        string GetMessage();
    }

    public interface IMensajeError
    {
        string GetMessage();
    }

    /// <summary>
    /// Creo una interfaz segregada solo para la creación de mensajes de bienvenida.
    /// </summary>
    public interface IUsuarioBienvenida
    {
        IMensajeDeBienvenida CrearMensajeBienvenida();
    }

}