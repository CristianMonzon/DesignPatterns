namespace Visitor
{
    /// <summary>
    /// Otra clave del patrón.
    /// El visitante define una operación específica para cada tipo concreto de mensaje. 
    /// Esto permite que, al llamar visitante.Visitar(this), se ejecute el método correspondiente al tipo real del elemento, 
    /// activando el doble despacho.
    /// </summary>
    public interface IVisitanteMensaje
    {
        void Visitar(Mensajes elemento);
        void Visitar(MensajeBienvenidaInformal elemento);
        void Visitar(MensajeBienvenidaNavidad elemento);
    }

    public class VisitanteImprimir : IVisitanteMensaje
    {
        public void Visitar(Mensajes elemento)
        {
            Console.WriteLine("Mensaje Formal: " + elemento.Texto);
        }

        public void Visitar(MensajeBienvenidaInformal elemento)
        {
            Console.WriteLine("Mensaje Informal:  " + elemento.Texto);
        }

        public void Visitar(MensajeBienvenidaNavidad elemento)
        {
            Console.WriteLine("Mensaje Navidad: " + elemento.Texto);
        }
    }

    public class VisitanteContarCaracteres : IVisitanteMensaje
    {
        public void Visitar(Mensajes elemento)
        {
            Console.WriteLine($"Soy un mensaje de tipo formal y tengo: {elemento.Texto.Length} caracteres");
        }

        public void Visitar(MensajeBienvenidaInformal elemento)
        {
            Console.WriteLine($"Soy un mensaje de tipo informal y tengo: {elemento.Texto.Length} caracteres");
        }

        public void Visitar(MensajeBienvenidaNavidad elemento)
        {
            Console.WriteLine($"Soy un mensaje de tipo navidad y tengo: {elemento.Texto.Length} caracteres");
        }
    }
}