namespace State
{
    public class NotasAdicionales : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre el patrón State:\n" +
                "- Evita condicionales extensos (if/switch) al delegar el comportamiento en objetos estado.\n" +
                "- Cada estado es responsable de su propia lógica, lo que mejora la cohesión.\n" +
                "- Los estados concretos están marcados como 'sealed' para evitar herencias que alteren su comportamiento.\n" +
                "- El contexto delega completamente en el estado actual mediante el método ObtenerMensaje().\n" +
                "- El patrón permite cambiar de estado en tiempo de ejecución, modificando dinámicamente el comportamiento del objeto.\n" +
                "- El ejemplo incluye un estado de error para mostrar que State también puede modelar situaciones excepcionales.\n" +
                "- Es ideal para flujos con etapas claras: procesos, ciclos de vida, validaciones o máquinas de estados.\n";
        }
    }
}
