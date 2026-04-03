namespace UNOGAME.Models;

public class Jogador
{
    public string Nome { get; set; } = string.Empty;
    public string Fotografia { get; set; } = string.Empty;
    public List<Carta> Cartas { get; set; } = new();
    public int N_Partidas_Jogadas { get; set; }
    public int N_Partidas_Ganhas { get; set; }
    public int N_Jogos_Jogados { get; set; }
    public int N_Jogos_Ganhos { get; set; }

    public void ReceberCarta(Carta carta)
    {
        Cartas.Add(carta);
    }

    public bool RemoverCarta(Carta carta)
    {
        return Cartas.Remove(carta);
    }
}
