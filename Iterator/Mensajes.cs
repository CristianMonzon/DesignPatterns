namespace Iterator
{
    public class MensajeA : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return "Mensaje desde la clase A";
        }
    }

    public class MensajeB : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return "Mensaje desde la clase B";
        }
    }
}
