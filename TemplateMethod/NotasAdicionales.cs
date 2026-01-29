namespace TemplateMethod
{
    public class NotasAdicionales : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre el patrón Template Method:\n" +
                "- La clase base define el flujo general del algoritmo.\n" +
                "- Las subclases implementan pasos concretos del proceso.\n" +
                "- Permite reutilizar la estructura del algoritmo sin duplicar código.\n" +
                "- Es ideal cuando varios procesos comparten la misma secuencia pero difieren en algunos pasos.\n" +
                "- A diferencia de Strategy, aquí el algoritmo NO cambia: solo cambian partes internas.\n";
        }
    }
}
