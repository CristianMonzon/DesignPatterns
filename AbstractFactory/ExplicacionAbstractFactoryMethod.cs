using AbstractFactory;

public class ExplicacionAbstractFactoryMethod : IUsuarioBienvenida
{
    public readonly IMensajeDeBienvenida mensajeDeBienvenida;

    public ExplicacionAbstractFactoryMethod()
    {
        mensajeDeBienvenida = new ExplicacionAbstractFactoryMethodMensaje();
    }
    
    public IMensajeDeBienvenida CrearMensajeBienvenida()
    {
        return mensajeDeBienvenida;
    }
}

public class ExplicacionAbstractFactoryMethodMensaje : IMensajeDeBienvenida
{
    public string GetMessage()
    {
        return
            "Este ejemplo implementa Abstract Factory porque:\n" +
            "- Se define una fábrica abstracta (IUsuarioFactory) que agrupa la creación de varios tipos de mensajes relacionados.\n" +
            "- Cada fábrica concreta (UsuarioAFactory, UsuarioBFactory, etc.) crea una familia completa de productos: bienvenida, despedida, error, etc.\n" +
            "- El código cliente trabaja únicamente con la fábrica abstracta y las interfaces de los productos, sin conocer las clases concretas.\n" +
            "- Se garantiza que todos los productos creados por una misma fábrica pertenecen a la misma familia y son compatibles entre sí.\n" +
            "- Puedes añadir nuevas familias completas (por ejemplo, UsuarioCFactory o UsuarioPremiumFactory) sin modificar el código existente, cumpliendo el principio OCP.\n" +
            "- También puedes segregar interfaces (IUsuarioBienvenida, IUsuarioDespedida, etc.) para que cada cliente dependa solo de lo que necesita, cumpliendo ISP.\n";
    }
}
