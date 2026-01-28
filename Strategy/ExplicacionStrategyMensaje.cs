namespace Strategy
{
    /// <summary>
    /// Explicación del patrón Strategy.
    /// Permite intercambiar algoritmos en tiempo de ejecución sin modificar el código del cliente.
    /// </summary>
    public class ExplicacionStrategyMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Patrón Strategy:\n" +
                "Permite definir una familia de algoritmos, encapsularlos y hacerlos intercambiables.\n" +
                "El contexto delega el comportamiento en la estrategia seleccionada, evitando condicionales y mejorando la extensibilidad.\n";
        }
    }
}
