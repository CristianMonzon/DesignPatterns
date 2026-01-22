namespace Factory
{
    public abstract class UsuarioBase
    {
        public abstract IMensajeDeBienvenida CrearMensaje();
    }

    public class UsuarioA : UsuarioBase
    {
        public override IMensajeDeBienvenida CrearMensaje()
        {
            return new MensajeBienvenidaA();
        }
    }

    public class MensajeBienvenidaA : IMensajeDeBienvenida
    {
        public string GetMessage() =>
            "Bienvenido usuario tipo A";
    }

    public class UsuarioB : UsuarioBase
    {
        public override IMensajeDeBienvenida CrearMensaje()
        {
            return new MensajeBienvenidaB();
        }
    }
    public class MensajeBienvenidaB : IMensajeDeBienvenida
    {
        public string GetMessage() =>
            "Hola usuario tipo B";
    }

    public class UsuarioC : UsuarioBase
    {
        public override IMensajeDeBienvenida CrearMensaje()
        {
            return new MensajeBienvenidaC();
        }
    }

    public class MensajeBienvenidaC : IMensajeDeBienvenida
    {
        public string GetMessage() =>
            "Saludos usuario tipo C";
    }
}