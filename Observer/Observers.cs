namespace Observer
{
    public interface IObserver
    {
        void Actualizar(IMensajeDeBienvenida mensaje);
    }

    public class LoggerObserver : IObserver
    {
        public void Actualizar(IMensajeDeBienvenida mensaje)
        {
            Console.WriteLine($"[Logger] Nuevo mensaje agregado: {mensaje.GetMessage()}");
        }
    }

    public class ContadorObserver : IObserver
    {
        private int _total = 0;

        public void Actualizar(IMensajeDeBienvenida mensaje)
        {
            _total++;
            Console.WriteLine($"[Contador] Total de mensajes: {_total}");
        }
    }

    public class AuditoriaObserver : IObserver
    {
        public void Actualizar(IMensajeDeBienvenida mensaje)
        {
            Console.WriteLine($"[Auditoría] Registrado mensaje de tipo: {mensaje.GetType().Name}");
        }
    }

    public class UppercaseObserver : IObserver
    {
        public void Actualizar(IMensajeDeBienvenida mensaje)
        {
            string textoOriginal = mensaje.GetMessage();
            string textoMayusculas = textoOriginal.ToUpperInvariant();

            Console.WriteLine($"[Uppercase] {textoMayusculas}");
        }
    }
}
