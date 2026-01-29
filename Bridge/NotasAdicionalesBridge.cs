namespace Bridge
{
    public class NotasAdicionalesBridge : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
            "Notas adicionales sobre bridge:\n" +
            "- La clave del patrón Bridge es que las abstracciones heredan de una clase base común (MensajeBridge)." +
            "- Esto permite que cada tipo de mensaje tenga su propia lógica, mientras que los formatos se inyectan como implementaciones independientes." +
            "- Gracias a esta separación, no necesitamos crear una clase por cada combinación de mensaje y formato." +
            "- La abstracción (MensajeBienvenidaA/B) y la implementación (FormatoMayusculas/ConPrefijo) se combinan dinámicamente mediante composición.";            
        }
    }
}



