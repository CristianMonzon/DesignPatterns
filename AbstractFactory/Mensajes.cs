namespace AbstractFactory
{
    public class MensajeBienvenidaA : IMensajeDeBienvenida
    {
        public string GetMessage() => "Bienvenido usuario tipo A";
    }

    public class MensajeDespedidaA : IMensajeDespedida
    {
        public string GetMessage() => "Adiós usuario tipo A";
    }

    public class MensajeErrorA : IMensajeError
    {
        public string GetMessage() => "Error para usuario tipo A";
    }

    public class MensajeBienvenidaB : IMensajeDeBienvenida
    {
        public string GetMessage() => "Hola usuario tipo B";
    }

    public class MensajeDespedidaB : IMensajeDespedida
    {
        public string GetMessage() => "Hasta luego usuario tipo B";
    }

    public class MensajeErrorB : IMensajeError
    {
        public string GetMessage() => "Error para usuario tipo B";
    }

}
