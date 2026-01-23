namespace Bridge
{
    public class ExplicacionBridgeMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Bridge porque:\n" +
                "- Se separa la abstracción (tipos de mensajes) de su implementación (formatos).\n" +
                "- MensajeBridge define la lógica general y delega el formateo a IFormatoMensaje.\n" +
                "- Las implementaciones de formato (simple, mayúsculas, prefijo) pueden cambiar sin afectar a los mensajes.\n" +
                "- Los tipos de mensajes (A, B, etc.) pueden crecer sin modificar los formatos.\n" +
                "- Se evita la explosión de clases que ocurriría combinando herencia múltiple.\n" +
                "- Abstracción e implementación evolucionan de forma independiente, cumpliendo el principio Open/Closed.\n";
        }
    }
}