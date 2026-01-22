public interface IPrototype<T>
{
    T Clonar();
}

public class MensajeCompleto : IPrototype<MensajeCompleto>
{
    public string Bienvenida { get; set; }
    public string Despedida { get; set; }
    public string Error { get; set; }
    public string Notas { get; set; }

    public MensajeCompleto Clonar()
    {
        return new MensajeCompleto
        {
            Bienvenida = this.Bienvenida,
            Despedida = this.Despedida,
            Error = this.Error,
            Notas = this.Notas
        };
    }

    public override string ToString()
    {
        return $"{Bienvenida}\n{Despedida}\n{Error}\n{Notas}";
    }
}

