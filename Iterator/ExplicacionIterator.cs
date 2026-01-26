namespace Iterator
{
    public class ExplicacionIterator : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Iterator porque:\n" +
                "- Permite recorrer una colección sin exponer su estructura interna.\n" +
                "- El iterador encapsula el estado del recorrido.\n" +
                "- La colección crea su propio iterador mediante CrearIterador().\n" +
                "- El cliente solo usa HasNext() y Next() para iterar.\n";
        }
    }
}
