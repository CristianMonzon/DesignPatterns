using Composite;

public class NotasAdicionales : IMensajeDeBienvenida
{
    public string GetMessage()
    {
        return
            "La idea del Composite en una frase: \n" +
            "- Cuando usas los objetos, todos se comportan igual.\n" +
            "- Cuando construyes la estructura, sí necesitas saber qué es MensajeSimple y qué es MensajeCompuesto.\n";
    }
}
