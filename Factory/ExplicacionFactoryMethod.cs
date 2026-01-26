using Factory;

public class ExplicacionFactoryMethod : UsuarioBase
{
    public readonly IMensajeDeBienvenida mensajeDeBienvenida;

    public ExplicacionFactoryMethod()
    {
        mensajeDeBienvenida = new ExplicacionFactoryMethodMensaje();
    }

    public override IMensajeDeBienvenida CrearMensaje()
    {
        return mensajeDeBienvenida;
    }
}

public class ExplicacionFactoryMethodMensaje : IMensajeDeBienvenida
{
    public string GetMessage()
    {
        return
            "Este ejemplo implementa Factory Method porque:\n" +
            "- La clase base UsuarioBase define un método abstracto CrearMensaje().\n" +
            "- Las subclases (UsuarioA, UsuarioB, UsuarioC) deciden qué mensaje concreto crear.\n" +
            "- El código cliente no conoce las clases concretas de los mensajes.\n" +
            "- Se cumple el principio de inversión de dependencias y OCP.\n" +
            "- Puedes crear nuevas clases que hereden de UsuarioBase (por ejemplo, UsuarioD) y nuevos mensajes (como ExplicacionMensajeUsuarioBase) sin modificar el código existente.\n";
    }
}
