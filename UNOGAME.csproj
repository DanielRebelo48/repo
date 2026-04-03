using UNOGAME.Enums;

namespace UNOGAME.Models;

public class Carta
{
    public int Id { get; set; }
    public SimboloCarta Simbolo { get; set; }
    public CorCarta Cor { get; set; }
    public int Pontos { get; set; }

    public Carta()
    {
    }

    public Carta(int id, SimboloCarta simbolo, CorCarta cor, int pontos)
    {
        Id = id;
        Simbolo = simbolo;
        Cor = cor;
        Pontos = pontos;
    }

    public override string ToString()
    {
        return $"{Cor} - {Simbolo} ({Pontos} pts)";
    }
}
