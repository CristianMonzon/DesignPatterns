
namespace Facade
{
    public class ExplicacionFacadeMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Façade porque:\n" +
                "- Proporciona una interfaz simple (BienvenidaFacade) para un subsistema complejo.\n" +
                "- El cliente solo llama a un método de alto nivel (CrearBienvenida) sin conocer los detalles internos.\n" +
                "- La fachada coordina múltiples componentes: validador, generador de texto, calculador de importancia, formateador y logger.\n" +
                "- El subsistema puede cambiar internamente sin afectar al código cliente.\n" +
                "- Reduce el acoplamiento: el cliente no depende de las clases internas del subsistema.\n" +
                "- Mejora la claridad del código al encapsular pasos complejos en una única operación.\n" +
                "- Façade no reemplaza al subsistema, solo lo simplifica para el uso externo.\n";
        }
    }
}
