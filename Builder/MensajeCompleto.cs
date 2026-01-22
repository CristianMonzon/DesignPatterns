public class MensajeCompleto
{
    public string Bienvenida { get; set; }
    public string Despedida { get; set; }
    public string Error { get; set; }
    public string Notas { get; set; }

    public override string ToString()
    {
        return $"{Bienvenida}\n{Despedida}\n{Notas}\n{Error}";
    }
}


