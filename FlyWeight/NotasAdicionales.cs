using Flyweight;

public class NotasAdicionales : IMensajeDeBienvenida
{
    public string GetMessage()
    {
        return
            "Notas adicionales sobre Flyweight:\n" +
            "- El objeto Flyweight (MensajeFlyweight) se crea una sola vez y se reutiliza para todos los mensajes.\n" +
            "- Esto solo es útil cuando la parte intrínseca es pesada: por ejemplo, una plantilla grande, un JSON complejo, un HTML extenso o un recurso cargado desde disco.\n" +
            "- La clave del patrón es separar:\n" +
            "    * Parte intrínseca (compartida, inmutable, costosa de crear).\n" +
            "    * Parte extrínseca (variable, específica de cada instancia).\n" +
            "- El constructor de MensajeDeBienvenidaFlyweight recibe la parte extrínseca (usuario, fecha, importancia), pero todos comparten el mismo Flyweight.\n" +
            "- Gracias a la fábrica, aunque generes 100, 1.000 o 10.000 mensajes, solo existe un único Flyweight en memoria.\n" +
            "- El beneficio real se nota cuando la parte intrínseca es grande: sin Flyweight tendrías miles de copias duplicadas.\n" +
            "- Flyweight no cambia cómo creas objetos, sino cómo compartes los que son costosos.\n";
    }
}
