using System.Runtime.Intrinsics.X86;

namespace ChainOfResponsability
{
    public interface IMensajeHandler
    {
        IMensajeHandler SetNext(IMensajeHandler next);
        string Handle(MensajeContexto contexto);
    }
    public class MensajeContexto
    {
        public string? Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int Importancia { get; set; }
    }
    public abstract class MensajeHandlerBase : IMensajeHandler
    {
        private IMensajeHandler? _next;

        /// <summary>
        /// Permite establecer el siguiente manejador en la cadena encadenando handlers de forma fluida.
        /// </summary>
        public IMensajeHandler SetNext(IMensajeHandler next)
        {
            _next = next;
            return next;
        }

        public virtual string Handle(MensajeContexto contexto)
        {
            return _next?.Handle(contexto)
                   ?? "Mensaje generado correctamente por la cadena.";
        }
    }
}