namespace UNOGAME.Models;

public class Mesa
{
    public List<Carta> CartasJogadas { get; set; } = new();
    public Baralho Baralho { get; set; } = new();

    public Carta? CartaDoTopo => CartasJogadas.Count > 0 ? CartasJogadas[^1] : null;

    public void JogarCarta(Carta carta)
    {
        CartasJogadas.Add(carta);
    }
}
