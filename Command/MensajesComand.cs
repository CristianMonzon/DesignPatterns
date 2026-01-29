
namespace Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class MensajeReceiver
    {
        public void EnviarMensaje(string usuario)
        {
            Console.WriteLine($"Mensaje enviado a {usuario}");
        }

        internal void DeshacerMensaje(string usuario)
        {
            Console.WriteLine($"Deshacer envio de mensaje a {usuario}");
        }
    }

    /// <summary>
    /// La clave del patron es que EnviarMensajeCommand hereda de Icommand
    /// </summary>
    public class EnviarMensajeCommand : ICommand
    {
        private readonly MensajeReceiver _receiver;
        private readonly string _usuario;

        public EnviarMensajeCommand(MensajeReceiver receiver, string usuario)
        {
            _receiver = receiver;
            _usuario = usuario;
        }

        public void Execute()
        {
            _receiver.EnviarMensaje(_usuario);
        }

        public void Undo()
        {
            _receiver.DeshacerMensaje(_usuario);            
        }
    }

    public class MensajeInvoker
    {
        private ICommand? _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Ejecutar una acción encapsulada en un objeto comando
        /// </summary>
        public void Ejecutar()
        {
            _command?.Execute();
        }

        public void Deshacer()
        {
            _command?.Undo();
        }
    }
}