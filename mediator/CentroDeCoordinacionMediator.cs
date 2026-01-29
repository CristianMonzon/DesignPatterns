namespace Mediator
{
    public interface IMediator
    {
        /// <summary>
        /// Punto de entrada para todos los eventos
        /// </summary>
        void Notificar(object remitente, EventoDeBienvenida evento, object? datos = null);
    }

    public enum EventoDeBienvenida
    {
        UsuarioRegistrado,
        UsuarioValidado,
        ErrorValidacion
    }

    /// <summary>
    /// Clase central del patron mediator
    /// </summary>
    /// <seealso cref="Mediator.IMediator" />
    public class CentroDeCoordinacionMediator : IMediator
    {
        public GeneradorDeMensajes Generador { get; set; }
        public LoggerDeBienvenida Logger { get; set; }
        public NotificadorDeUsuarios Notificador { get; set; }
        public ValidadorDeUsuario Validador { get; set; }

        /// <summary>
        /// Método central de coordinación del patrón Mediator.
        /// Los componentes llaman a este método para notificar un evento y se decide qué otros componentes deben reaccionar.
        /// Ningún componente conoce a los demás: toda la interacción pasa por aquí.
        /// </summary>
        public void Notificar(object remitente, EventoDeBienvenida evento, object? datos = null)
        {
            switch (evento)
            {
                case EventoDeBienvenida.UsuarioRegistrado:
                    Logger.Registrar("'Nuevo usuario registrado.'");
                    Validador.Validar(datos);
                    break;

                case EventoDeBienvenida.UsuarioValidado:
                    if (datos is Usuario)
                    {
                        var usuario = (Usuario)datos;
                        var mensaje = Generador.Mensaje(usuario);
                        Notificador.Enviar(mensaje);
                        Logger.Registrar("'Mensaje de bienvenida enviado.'");
                    }
                    break;

                case EventoDeBienvenida.ErrorValidacion:
                    Logger.Registrar("'Error de validación.'");
                    break;
            }
        }
    }
}