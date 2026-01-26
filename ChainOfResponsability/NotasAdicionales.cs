using System.Diagnostics;

namespace ChainOfResponsability
{
    public class NotasAdicionales : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre Chain of Responsibility:\n" +
                "- La petición se envía al primer handler de la cadena y fluye secuencialmente.\n" +
                "- Cada handler decide si procesa la petición o la delega al siguiente.\n" +
                "- El cliente solo conoce el primer handler; el resto de la cadena está desacoplada.\n" +
                "- La cadena puede ampliarse, reducirse o reordenarse sin modificar el cliente.\n" +
                "- La cadena se detiene en el primer handler que devuelve un resultado.\n";
        }
    }
}
