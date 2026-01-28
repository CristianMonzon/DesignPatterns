
namespace Mediator
{
    public abstract class ComponenteBase
    {
        protected IMediator _mediator;

        protected ComponenteBase(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
    public class RegistroDeUsuarios : ComponenteBase
    {
        public RegistroDeUsuarios(IMediator mediator) : base(mediator) { }

        public void Informar(Usuario usuario)
        {
            var remitente = this;
            var evento = EventoDeBienvenida.UsuarioRegistrado;
            _mediator.Notificar(remitente, evento, usuario);
        }
    }

    public class GeneradorDeMensajes : ComponenteBase
    {
        public GeneradorDeMensajes(IMediator mediator) : base(mediator) { }

        public string Mensaje(Usuario? usuario)
        {
            if (usuario == null)
                return $"'No hay un usuario registrado'";
            else
                return $"'Bienvenido, {usuario.Nombre}. ¡Nos alegra tenerte aquí!'";
        }
    }

    public class LoggerDeBienvenida : ComponenteBase
    {
        public LoggerDeBienvenida(IMediator mediator) : base(mediator) { }

        public void Registrar(string mensaje)
        {
            Console.WriteLine($"[LoggerDeBienvenida] El log de bienvenida es {mensaje}");
        }
    }

    public class NotificadorDeUsuarios : ComponenteBase
    {
        public NotificadorDeUsuarios(IMediator mediator) : base(mediator) { }

        public void Enviar(string mensaje)
        {
            Console.WriteLine($"[NotificadorDeUsuarios] Notificación de mensaje enviado:\n {mensaje}");
        }
    }

    public class ValidadorDeUsuario : ComponenteBase
    {
        public ValidadorDeUsuario(IMediator mediator) : base(mediator) { }

        public void Validar(object? datos)
        {
            Console.WriteLine($"[ValidadorDeUsuario] Validación de usuario");
            if (datos is Usuario usuario && !string.IsNullOrWhiteSpace(usuario.Nombre))
            {
                var remitente = this;
                var evento = EventoDeBienvenida.UsuarioValidado;                
                _mediator.Notificar(remitente,evento,datos);
            }
            else
            {
                var remitente = this;
                var evento = EventoDeBienvenida.ErrorValidacion;
                _mediator.Notificar(remitente,evento);
            }
        }
    }
}