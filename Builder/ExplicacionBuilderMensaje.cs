namespace Builder
{
    public interface IMensajeDeBienvenida
    {
        string GetMessage();
    }
    public class ExplicacionBuilderMensaje : IMensajeDeBienvenida
    {
        public string GetMessage() { 
            return "Este ejemplo implementa el patrón Builder porque:\n" + 
                "- Se define un objeto complejo (MensajeCompleto) compuesto por varias partes opcionales.\n" + 
                "- El builder (MensajeBuilder) permite construir el mensaje paso a paso, configurando solo las partes necesarias.\n" + 
                "- El director (MensajeDirector) encapsula la lógica de construcción para distintos tipos de mensajes.\n" + 
                "- El cliente puede crear variaciones del mismo objeto sin necesidad de múltiples constructores.\n" + 
                "- Puedes añadir nuevas partes al mensaje sin modificar el código cliente, cumpliendo el principio OCP.\n"; }
    }
}
