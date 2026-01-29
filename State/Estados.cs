namespace State
{
    /// <summary>
    /// Clave del patron State
    /// Definimos como se comporta el contexto del mensaje
    /// </summary>
    public interface IEstadoMensaje
    {
        string ObtenerMensaje();
    }

    /// <summary>
    /// Estado concreto del patrón State: representa el inicio del proceso del mensaje.
    /// Clase sealed (sellada a herencias): Queremos evitar herencias que alteren la lógica del patrón.
    /// </summary>
    /// <seealso cref="State.IEstadoMensaje" />
    public sealed class EstadoInicial : IEstadoMensaje
    {
        public string ObtenerMensaje()
        {
            return "Inicio del proceso...";
        }
    }

    /// <summary>
    /// Estado concreto del patrón State: el mensaje se está generando.
    /// </summary>
    /// <seealso cref="State.IEstadoMensaje" />
    public sealed class EstadoEnProceso : IEstadoMensaje
    {
        public string ObtenerMensaje()
        {
            return "Generando mensaje de bienvenida...";
        }
    }

    /// <summary> 
    /// Estado concreto del patrón State: el mensaje ya fue generado correctamente. 
    /// </summary>
    public sealed class EstadoFinalizado : IEstadoMensaje
    {
        public string ObtenerMensaje()
        {
            {
                return "Mensaje de bienvenida completado.";
            }
        }
    }

    /// <summary>
    /// Estado concreto del patrón State: representa una situación de error en la generación del mensaje.
    /// </summary>
    /// <seealso cref="State.IEstadoMensaje" />
    public sealed class EstadoError : IEstadoMensaje
    {
        public string ObtenerMensaje()
        {
            return "Hubo un error generando el mensaje.";
        }
    }
}