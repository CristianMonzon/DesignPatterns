namespace Composite
{
    public class ExplicacionCompositeMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Composite porque:\n" +
                "- Permite tratar objetos individuales (MensajeSimple) y compuestos (MensajeCompuesto) de la misma manera.\n" +
                "- Ambos implementan la interfaz IMensajeDeBienvenida, por lo que el cliente no distingue entre un mensaje simple o un grupo de mensajes.\n" +
                "- Esto se ve claramente cuando definimos:\n" +
                "    IMensajeDeBienvenida mensaje1 = new MensajeSimple(\"Hola usuario\");\n" +
                "    IMensajeDeBienvenida mensaje2 = new MensajeSimple(\"Bienvenido al sistema\");\n" +
                "    MensajeCompuesto mensajeCompuesto = new MensajeCompuesto();\n" +
                "- MensajeCompuesto actúa como un contenedor que puede almacenar otros IMensajeDeBienvenida, formando una estructura jerárquica.\n" +
                "- El cliente solo llama a GetMessage(), y Composite se encarga de recorrer los elementos internos.\n" +
                "- Esto evita condicionales del tipo 'si es simple haz esto, si es compuesto haz lo otro'.\n" +
                "- Composite es ideal para representar estructuras parte-todo como carpetas/archivos, menús/submenús o grupos de mensajes.\n";
        }
    }

}
