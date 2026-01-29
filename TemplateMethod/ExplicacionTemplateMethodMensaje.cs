namespace TemplateMethod
{
    public class ExplicacionTemplateMethodMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
            "Patrón Template Method:\n" +
            "Define el esqueleto de un algoritmo en una clase base. " +
            "Las subclases implementan pasos específicos, pero la estructura general " +
            "del proceso permanece fija. Esto permite reutilizar el flujo del algoritmo " +
            "y variar únicamente los detalles necesarios.\n";
        }
    }
}