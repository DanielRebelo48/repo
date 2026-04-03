namespace UNOGAME.Models;

public class Baralho
{
    public List<Carta> Cartas { get; set; } = new();

    public Carta? ComprarCarta()
    {
        if (Cartas.Count == 0)
        {
            return null;
        }

        Carta carta = Cartas[0];
        Cartas.RemoveAt(0);
        return carta;
    }

    public void AdicionarCarta(Carta carta)
    {
        Cartas.Add(carta);
    }
}
