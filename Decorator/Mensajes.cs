namespace Decorator
{
    


    public class Mensajes : IMensajeDeBienvenida
    {
        private readonly string _texto;

        public Mensajes(string texto)
        {
            _texto = texto;
        }

        public string GetMessage()
        {
            return _texto;
        }
    }

}