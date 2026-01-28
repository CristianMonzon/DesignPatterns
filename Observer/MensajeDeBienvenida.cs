namespace Observer
{
    public interface IMensajeDeBienvenida
    {
        string GetMessage();
    }
    public class MensajeDeBienvenida : IMensajeDeBienvenida
    {
        private readonly string _mensaje;

        public MensajeDeBienvenida(string mensaje)
        {
            _mensaje = mensaje;
        }

        public string GetMessage()
        {
            return _mensaje;
        }
    }

}
