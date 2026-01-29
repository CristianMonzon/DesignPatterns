using ChainOfResponsability;

Console.WriteLine("Patrón ChainOfResponsability -> Encadenamos validaciones independientes sin que el cliente conozca la estructura de la cadena");

{
    Console.WriteLine("Caso contexto válido");
    var contexto = new MensajeContexto
    {
        Usuario = "usuario A",
        Fecha = DateTime.Now,
        Importancia = 2
    };

    var cadena = new ValidarUsuarioHandler();

    IMensajeHandler generarMensaje = new GenerarMensajeHandler();
    IMensajeHandler validarFecha = new ValidarFechaHandler();
    IMensajeHandler validarImportancia = new ValidarImportanciaHandler();
    cadena.SetNext(generarMensaje).SetNext(validarFecha).SetNext(validarImportancia);

    Console.WriteLine(cadena.Handle(contexto));
    Console.WriteLine();
}

{
    var contextoInvalido = new MensajeContexto
    {
        Usuario = null,
        Fecha = DateTime.Now,
        Importancia = 2
    };

    var cadena = new ValidarUsuarioHandler();

    IMensajeHandler generarMensaje = new GenerarMensajeHandler();
    IMensajeHandler validarFecha = new ValidarFechaHandler();
    IMensajeHandler validarImportancia = new ValidarImportanciaHandler();
    cadena.SetNext(generarMensaje).SetNext(validarFecha).SetNext(validarImportancia);

    Console.WriteLine("Caso - Usuario inválido");
    Console.WriteLine(cadena.Handle(contextoInvalido));
    Console.WriteLine();
}


{
    var contextoInvalido = new MensajeContexto
    {
        Usuario = "Usuario B",
        Fecha = DateTime.Now.AddDays(10),
        Importancia = 1
    };

    var cadena = new ValidarUsuarioHandler();

    IMensajeHandler generarMensaje = new GenerarMensajeHandler();
    IMensajeHandler validarFecha = new ValidarFechaHandler();
    IMensajeHandler validarImportancia = new ValidarImportanciaHandler();
    cadena.SetNext(generarMensaje).SetNext(validarFecha).SetNext(validarImportancia);

    Console.WriteLine("Caso - Fecha futura");
    Console.WriteLine(cadena.Handle(contextoInvalido));
    Console.WriteLine();
}

{
    var contextoInvalido = new MensajeContexto
    {
        Usuario = null,
        Fecha = DateTime.Now,
        Importancia = 5
    };

    var cadena = new ValidarUsuarioHandler();

    IMensajeHandler generarMensaje = new GenerarMensajeHandler();
    IMensajeHandler validarFecha = new ValidarFechaHandler();
    IMensajeHandler validarImportancia = new ValidarImportanciaHandler();
    cadena.SetNext(generarMensaje).SetNext(validarFecha).SetNext(validarImportancia);

    Console.WriteLine("Caso - Valor de importancia inválido");
    Console.WriteLine(cadena.Handle(contextoInvalido));
    Console.WriteLine();
}

{
    var explicacionChainOfResponsibility = new ExplicacionChainOfResponsibility();
    Console.WriteLine(explicacionChainOfResponsibility.GetMessage());
}

{
    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());

}

Console.WriteLine("Fin patrón ChainOfResponsability");

