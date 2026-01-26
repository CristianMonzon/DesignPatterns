using Factory;
public class NotasAdicionales : UsuarioBase
{
    public readonly IMensajeDeBienvenida mensajeDeBienvenida;

    public NotasAdicionales()
    {
        mensajeDeBienvenida = new NotasAdicionalesMensaje();
    }

    public override IMensajeDeBienvenida CrearMensaje()
    {
        return mensajeDeBienvenida;
    }
}

public class NotasAdicionalesMensaje : IMensajeDeBienvenida
{
    public string GetMessage()
    {
        return
            "Notas adicionales:\n" +
            "- Las subclases (UsuarioA, UsuarioB, UsuarioC) podrían recibir la interfaz IMensajeDeBienvenida mediante inyección de dependencias.\n" +
            "- En ese caso, la creación del mensaje ya no dependería de la subclase, sino del código cliente.\n" +
            "- Este enfoque transforma el comportamiento en una estrategia intercambiable, lo que nos lleva al patrón Strategy.\n" +
            "- Esto demuestra cómo un mismo diseño puede evolucionar hacia distintos patrones según dónde situemos la responsabilidad de creación.\n" +
            "- La escencia del patrón es :'Cada objeto es responsable de crear su propia copia'.\n";
    }
}
